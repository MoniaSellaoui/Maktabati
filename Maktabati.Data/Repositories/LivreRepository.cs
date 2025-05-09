using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Context;
using Maktabati.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Maktabati.Data.Repositories
{
    public class LivreRepository
    {
        private readonly BibliothequeContext _context;

        public LivreRepository(BibliothequeContext context)
        {
            _context = context;
        }

        public async Task<List<Livre>> GetAll()
        {
            return await _context.Livres.ToListAsync();
        }

        public async Task<Livre?> GetById(int id)
        {
            return await _context.Livres.FindAsync(id);
        }

        public async Task Add(Livre livre)
        {
            await _context.Livres.AddAsync(livre);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Livre livre)
        {
            _context.Livres.Update(livre);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var livre = await _context.Livres.FindAsync(id);
            if (livre != null)
            {
                _context.Livres.Remove(livre);
                await _context.SaveChangesAsync();
            }
        }
    }
}
