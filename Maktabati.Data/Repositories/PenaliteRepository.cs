using Maktabati.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maktabati.Data.Repositories
{
    public class PenaliteRepository
    {
        private readonly DbContext _context;

        public PenaliteRepository(DbContext context)
        {
            _context = context;
        }

        // Ajouter une pénalité
        public async Task AjouterPenaliteAsync(Penalite penalite)
        {
            await _context.Set<Penalite>().AddAsync(penalite);
            await _context.SaveChangesAsync();
        }

        // Fix for CS8603: Ensure nullability is handled explicitly by adding null checks or using null-forgiving operator (!).

        // Récupérer une pénalité par son Id
        public async Task<Penalite?> ObtenirPenaliteParIdAsync(int id)
        {
            return await _context.Set<Penalite>().FindAsync(id);
        }

        // Récupérer toutes les pénalités
        public async Task<IEnumerable<Penalite>> ObtenirToutesLesPenalitesAsync()
        {
            return await _context.Set<Penalite>().ToListAsync();
        }

        // Récupérer les pénalités non payées
        public async Task<IEnumerable<Penalite>> ObtenirPenalitesNonPayeesAsync()
        {
            return await _context.Set<Penalite>()
                .Where(p => !p.EstPayee)
                .ToListAsync();
        }

        // Récupérer les pénalités par emprunt
        public async Task<Penalite?> ObtenirPenaliteParEmpruntIdAsync(int empruntId)
        {
            return await _context.Set<Penalite>()
                .FirstOrDefaultAsync(p => p.EmpruntId == empruntId);
        }

        // Mettre à jour une pénalité
        public async Task MettreAJourPenaliteAsync(Penalite penalite)
        {
            _context.Set<Penalite>().Update(penalite);
            await _context.SaveChangesAsync();
        }

        // Supprimer une pénalité
        public async Task SupprimerPenaliteAsync(int id)
        {
            var penalite = await ObtenirPenaliteParIdAsync(id);
            if (penalite != null)
            {
                _context.Set<Penalite>().Remove(penalite);
                await _context.SaveChangesAsync();
            }
        }
    }
}