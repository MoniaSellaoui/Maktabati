using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class LivreService
    {
        private readonly LivreRepository _livreRepository;

        public LivreService(LivreRepository livreRepository)
        {
            _livreRepository = livreRepository;
        }

        // Ajouter un nouveau livre
        public async Task AjouterLivre(Livre livre)
        {
            if (livre == null)
                throw new ArgumentNullException(nameof(livre));

            // Par défaut, le livre est disponible
            livre.Statut = "Disponible";
            await _livreRepository.Add(livre);
        }

        // Mettre à jour un livre existant
        public async Task MettreAJourLivre(Livre livre)
        {
            if (livre == null)
                throw new ArgumentNullException(nameof(livre));

            var livreExistant = await _livreRepository.GetById(livre.Id);
            if (livreExistant == null)
                throw new InvalidOperationException("Livre non trouvé.");

            await _livreRepository.Update(livre);
        }

        // Supprimer un livre
        public async Task SupprimerLivre(int id)
        {
            var livre = await _livreRepository.GetById(id);
            if (livre == null)
                throw new InvalidOperationException("Livre non trouvé.");

            await _livreRepository.Delete(id);
        }

        // Récupérer un livre par son Id
        public async Task<Livre?> ObtenirLivreParId(int id)
        {
            return await _livreRepository.GetById(id);
        }

        // Récupérer tous les livres
        public async Task<List<Livre>> ObtenirTousLesLivres()
        {
            return await _livreRepository.GetAll();
        }

        // Rechercher des livres par mot-clé (titre, auteur, catégorie)
        public async Task<List<Livre>> RechercherLivres(string motCle)
        {
            if (string.IsNullOrWhiteSpace(motCle))
                return new List<Livre>();

            var livres = await _livreRepository.GetAll();
            return livres.FindAll(l =>
                l.Titre.Contains(motCle, StringComparison.OrdinalIgnoreCase) ||
                l.Auteur.Contains(motCle, StringComparison.OrdinalIgnoreCase) ||
                l.Categorie.Contains(motCle, StringComparison.OrdinalIgnoreCase));
        }

        // Mettre à jour le statut d'un livre (par exemple : Disponible, Emprunté, Réservé)
        public async Task MettreAJourStatutLivre(int id, string nouveauStatut)
        {
            var livre = await _livreRepository.GetById(id);
            if (livre == null)
                throw new InvalidOperationException("Livre non trouvé.");

            livre.Statut = nouveauStatut;
            await _livreRepository.Update(livre);
        }
    }
}