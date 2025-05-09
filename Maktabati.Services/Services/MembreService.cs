using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class MembreService
    {
        private readonly EmpruntRepository _empruntRepository;
        private readonly LivreRepository _livreRepository;

        public MembreService(EmpruntRepository empruntRepository, LivreRepository livreRepository)
        {
            _empruntRepository = empruntRepository;
            _livreRepository = livreRepository;
        }

        public async Task ReserverLivre(Livre livre)
        {
            // Implémentation de la réservation de livre
            if (livre == null)
                throw new ArgumentNullException(nameof(livre));

            // Logique de réservation
            livre.Statut = "Réservé";
            await _livreRepository.Update(livre);
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
