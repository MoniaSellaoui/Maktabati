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
    public class MembreRepository
    {
        private readonly BibliothequeContext _context;

        public MembreRepository(BibliothequeContext context)
        {
            _context = context;
        }

        public async Task<List<Membre>> GetAll()
        {
            return await _context.Membres.ToListAsync();
        }

        public async Task<Membre> GetById(int id)
        {
            return await _context.Membres.FindAsync(id);
        }

        public async Task<Membre> FindByEmail(string email)
        {
            return await _context.Membres
                .FirstOrDefaultAsync(m => m.Email == email);
        }

        public async Task Add(Membre membre)
        {
            await _context.Membres.AddAsync(membre);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Membre membre)
        {
            _context.Membres.Update(membre);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var membre = await _context.Membres.FindAsync(id);
            if (membre != null)
            {
                _context.Membres.Remove(membre);
                await _context.SaveChangesAsync();
            }
        }
    }
    }
