using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Context;
using Maktabati.Data.Entities;

namespace Maktabati.Data.Repositories
{
    public class EmpruntRepository
    {
        private readonly BibliothequeContext _context;

        public EmpruntRepository(BibliothequeContext context)
        {
            _context = context;
        }

        public async Task<List<Emprunt>> GetAll()
        {
            return await _context.Emprunts
                .Include(e => e.Livre)
                .Include(e => e.Membre)
                .ToListAsync();
        }

        public async Task<List<Emprunt>> GetByMembre(int membreId)
        {
            return await _context.Emprunts
                .Include(e => e.Livre)
                .Where(e => e.MembreId == membreId)
                .ToListAsync();
        }

        public async Task<Emprunt> GetById(int id)
        {
            return await _context.Emprunts
                .Include(e => e.Livre)
                .Include(e => e.Membre)
                .Include(e => e.Penalite)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Add(Emprunt emprunt)
        {
            await _context.Emprunts.AddAsync(emprunt);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Emprunt emprunt)
        {
            _context.Emprunts.Update(emprunt);
            await _context.SaveChangesAsync();
        }

        public async Task MarkAsReturned(int id, DateTime dateRetour)
        {
            var emprunt = await _context.Emprunts.FindAsync(id);
            if (emprunt != null)
            {
                emprunt.DateRetourEffective = dateRetour;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var emprunt = await _context.Emprunts.FindAsync(id);
            if (emprunt != null)
            {
                _context.Emprunts.Remove(emprunt);
                await _context.SaveChangesAsync();
            }
        }
    }
}
