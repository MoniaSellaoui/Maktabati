using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Maktabati.Data.Context
{
    public class BibliothequeContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Administrateur> Administrateurs { get; set; }
        public DbSet<Membre> Membres { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Penalite> Penalites { get; set; }

        public BibliothequeContext(DbContextOptions<BibliothequeContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Maktabati.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Utilisateur>()
                .HasDiscriminator<string>("TypeUtilisateur")
                .HasValue<Administrateur>("Administrateur")
                .HasValue<Membre>("Membre");

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Livre)
                .WithMany(l => l.Emprunts)
                .HasForeignKey(e => e.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Membre)
                .WithMany(m => m.Emprunts)
                .HasForeignKey(e => e.MembreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Penalite)
                .WithOne(p => p.Emprunt)
                .HasForeignKey<Penalite>(p => p.EmpruntId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Livre)
                .WithMany(l => l.Reservations)
                .HasForeignKey(r => r.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Membre)
                .WithMany(m => m.Reservations)
                .HasForeignKey(r => r.MembreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Membre)
                .WithMany(m => m.Notifications)
                .HasForeignKey(n => n.MembreId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
