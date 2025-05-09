using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class AdministrateurService
    {
        private readonly LivreRepository _livreRepository;
        private readonly EmpruntRepository _empruntRepository;
        private readonly MembreRepository _membreRepository;

        public AdministrateurService(
            LivreRepository livreRepository,
            EmpruntRepository empruntRepository,
            MembreRepository membreRepository)
        {
            _livreRepository = livreRepository;
            _empruntRepository = empruntRepository;
            _membreRepository = membreRepository;
        }

        public async Task AjouterLivre(Livre livre)
        {
            // Implémentation de l'ajout de livre
            if (livre == null)
                throw new ArgumentNullException(nameof(livre));

            // Par défaut, le livre est disponible
            livre.Statut = "Disponible";
            await _livreRepository.Add(livre);
        }

        public async Task EnregistrerEmprunt(Emprunt emprunt)
        {
            // Implémentation de l'enregistrement d'emprunt
            if (emprunt == null)
                throw new ArgumentNullException(nameof(emprunt));

            // Vérifier si le membre existe et a un abonnement actif
            var membre = await _membreRepository.GetById(emprunt.MembreId);
            if (membre == null)
                throw new InvalidOperationException("Membre non trouvé.");

            if (!membre.AbonnementActif)
                throw new InvalidOperationException("L'abonnement du membre n'est pas actif.");

            // Vérifier si le livre est disponible
            var livre = await _livreRepository.GetById(emprunt.LivreId);
            if (livre == null)
                throw new InvalidOperationException("Livre non trouvé.");

            if (livre.Statut != "Disponible")
                throw new InvalidOperationException("Ce livre n'est pas disponible pour l'emprunt.");

            // Configurer l'emprunt
            emprunt.DateEmprunt = DateTime.Now;
            emprunt.DateRetourPrevue = DateTime.Now.AddDays(14);
            emprunt.DateRetourEffective = null;

            // Mettre à jour le statut du livre
            livre.Statut = "Emprunté";
            await _livreRepository.Update(livre);

            // Enregistrer l'emprunt
            await _empruntRepository.Add(emprunt);
        }
    }
    }
