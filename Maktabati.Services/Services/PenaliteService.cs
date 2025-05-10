using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class PenaliteService
    {
        private readonly PenaliteRepository _penaliteRepository;
        private readonly EmpruntRepository _empruntRepository;

        public PenaliteService(PenaliteRepository penaliteRepository, EmpruntRepository empruntRepository)
        {
            _penaliteRepository = penaliteRepository;
            _empruntRepository = empruntRepository;
        }

        // Fix for CS9035: Ensure the required 'Penalite.Emprunt' property is initialized when creating a Penalite object.  
        public async Task CalculerPenalitePourEmprunt(int empruntId, float montantParJourDeRetard)
        {
            var emprunt = await _empruntRepository.GetById(empruntId);
            if (emprunt == null)
                throw new InvalidOperationException("Emprunt non trouvé.");

            if (emprunt.DateRetourEffective == null || emprunt.DateRetourEffective <= emprunt.DateRetourPrevue)
                return; // Pas de pénalité si le livre a été retourné à temps  

            // Calculer le nombre de jours de retard  
            var joursDeRetard = (emprunt.DateRetourEffective.Value - emprunt.DateRetourPrevue).Days;
            if (joursDeRetard <= 0)
                return;

            // Créer une pénalité avec la propriété 'Emprunt' correctement initialisée  
            var penalite = new Penalite
            {
                EmpruntId = emprunt.Id,
                Montant = joursDeRetard * montantParJourDeRetard,
                Date = DateTime.Now,
                EstPayee = false,
                Emprunt = emprunt // Initialize the required 'Emprunt' property  
            };

            await _penaliteRepository.AjouterPenaliteAsync(penalite);
        }

        // Marquer une pénalité comme payée
        public async Task MarquerPenaliteCommePayee(int penaliteId)
        {
            var penalite = await _penaliteRepository.ObtenirPenaliteParIdAsync(penaliteId);
            if (penalite == null)
                throw new InvalidOperationException("Pénalité non trouvée.");

            penalite.EstPayee = true;
            await _penaliteRepository.MettreAJourPenaliteAsync(penalite);
        }

        // Récupérer les pénalités d'un membre
        public async Task<List<Penalite>> ObtenirPenalitesParMembre(int membreId)
        {
            var emprunts = await _empruntRepository.GetByMembre(membreId);
            var penalites = new List<Penalite>();

            foreach (var emprunt in emprunts)
            {
                var penalite = await _penaliteRepository.ObtenirPenaliteParEmpruntIdAsync(emprunt.Id);
                if (penalite != null)
                {
                    penalites.Add(penalite);
                }
            }

            return penalites;
        }

        // Récupérer les pénalités non payées
        public async Task<List<Penalite>> ObtenirPenalitesNonPayees()
        {
            return (await _penaliteRepository.ObtenirPenalitesNonPayeesAsync()).ToList();
        }
    }
}