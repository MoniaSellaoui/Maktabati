using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class EmpruntService
    {
        private readonly EmpruntRepository _empruntRepository;
        private readonly LivreRepository _livreRepository;
        private readonly MembreRepository _membreRepository;

        public EmpruntService(
            EmpruntRepository empruntRepository,
            LivreRepository livreRepository,
            MembreRepository membreRepository)
        {
            _empruntRepository = empruntRepository;
            _livreRepository = livreRepository;
            _membreRepository = membreRepository;
        }

        // Enregistrer un nouvel emprunt
        public async Task EnregistrerEmprunt(Emprunt emprunt)
        {
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

        // Marquer un emprunt comme retourné
        public async Task MarquerCommeRetourne(int empruntId, DateTime dateRetourEffective)
        {
            var emprunt = await _empruntRepository.GetById(empruntId);
            if (emprunt == null)
                throw new InvalidOperationException("Emprunt non trouvé.");

            // Mettre à jour la date de retour effective
            emprunt.DateRetourEffective = dateRetourEffective;

            // Mettre à jour le statut du livre
            var livre = await _livreRepository.GetById(emprunt.LivreId);
            if (livre != null)
            {
                livre.Statut = "Disponible";
                await _livreRepository.Update(livre);
            }

            // Mettre à jour l'emprunt
            await _empruntRepository.Update(emprunt);
        }

        // Récupérer tous les emprunts
        public async Task<List<Emprunt>> ObtenirTousLesEmprunts()
        {
            return await _empruntRepository.GetAll();
        }

        // Récupérer les emprunts d'un membre
        public async Task<List<Emprunt>> ObtenirEmpruntsParMembre(int membreId)
        {
            return await _empruntRepository.GetByMembre(membreId);
        }

        // Supprimer un emprunt
        public async Task SupprimerEmprunt(int empruntId)
        {
            var emprunt = await _empruntRepository.GetById(empruntId);
            if (emprunt == null)
                throw new InvalidOperationException("Emprunt non trouvé.");

            // Mettre à jour le statut du livre avant de supprimer l'emprunt
            var livre = await _livreRepository.GetById(emprunt.LivreId);
            if (livre != null)
            {
                livre.Statut = "Disponible";
                await _livreRepository.Update(livre);
            }

            await _empruntRepository.Delete(empruntId);
        }


        public async Task ProlongerEmprunt(Emprunt emprunt)
        {
            // Implémentation de la prolongation d'emprunt
            if (emprunt == null)
                throw new ArgumentNullException(nameof(emprunt));

            // Vérifier si le livre n'est pas réservé par un autre membre
            var livre = await _livreRepository.GetById(emprunt.LivreId);
            if (livre.Statut == "Réservé")
                throw new InvalidOperationException("Ce livre est réservé par un autre membre et ne peut pas être prolongé.");

            // Prolonger la date de retour
            emprunt.DateRetourPrevue = emprunt.DateRetourPrevue.AddDays(14);
            await _empruntRepository.Update(emprunt);
        }
    }
}