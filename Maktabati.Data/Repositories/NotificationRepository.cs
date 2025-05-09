using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Microsoft.EntityFrameworkCore;



namespace Maktabati.Data.Repositories
    {
        public class NotificationRepository
        {
            private readonly Microsoft.EntityFrameworkCore.DbContext _context;

            public NotificationRepository(Microsoft.EntityFrameworkCore.DbContext context)
            {
                _context = context;
            }

        // Corrected method to fix CS1503 error
        public async Task AjouterNotificationAsync(Notification notification)
        {
            await _context.Set<Notification>().AddAsync(notification); // Fixed the incorrect method call
            await _context.SaveChangesAsync();
        }

            // Récupérer une notification par son Id
            public async Task<Notification> ObtenirNotificationParIdAsync(int id)
            {
                return await _context.Set<Notification>().FindAsync(id);
            }

            // Récupérer toutes les notifications d'un membre
            public async Task<IEnumerable<Notification>> ObtenirNotificationsParMembreIdAsync(int membreId)
            {
                return await _context.Set<Notification>()
                    .Where(n => n.MembreId == membreId)
                    .ToListAsync();
            }

            // Mettre à jour une notification
            public async Task MettreAJourNotificationAsync(Notification notification)
            {
                _context.Set<Notification>().Update(notification);
                await _context.SaveChangesAsync();
            }

            // Supprimer une notification
            public async Task SupprimerNotificationAsync(int id)
            {
                var notification = await ObtenirNotificationParIdAsync(id);
                if (notification != null)
                {
                    _context.Set<Notification>().Remove(notification);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

