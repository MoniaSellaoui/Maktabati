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
    public class ReservationRepository
    {
        private readonly BibliothequeContext _context;

        public ReservationRepository(BibliothequeContext context)
        {
            _context = context;
        }

        public async Task<List<Reservation>> GetAll()
        {
            return await _context.Reservations
                .Include(r => r.Livre)
                .Include(r => r.Membre)
                .ToListAsync();
        }

        public async Task<Reservation> GetById(int id)
        {
            return await _context.Reservations
                .Include(r => r.Livre)
                .Include(r => r.Membre)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task Add(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Reservation reservation)
        {
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }
    }
}

