using Microsoft.EntityFrameworkCore;
using RecipeNotebook.Data.Entities;

namespace RecipeNotebook.Data.Context
{
    public class RecipeContext : DbContext
    {
        // Constructeur utilisé par EF Core Tools
        public RecipeContext()
        {
        }

        // Constructeur avec DbContextOptions utilisé par l'application
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                // Configuration par défaut pour les outils EF Core
                options.UseSqlite("Data Source=recipes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de la relation Recipe - Category (Many-to-One)
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Category)
                .WithMany(c => c.Recipes)
                .HasForeignKey(r => r.CategoryId)
                // A la suppression d'une catégorie, les recettes associées seront sans catégorie
                .OnDelete(DeleteBehavior.SetNull);

            // Configuration des contraintes de validation
            modelBuilder.Entity<Recipe>()
                .Property(r => r.Title)
                .IsRequired()
                .HasMaxLength(50);
        }

        // Méthode pour initialiser la base de données avec des données de test
        public void Seed()
        {
            if (!Categories.Any())
            {
                Categories.AddRange(
                    new Category
                    {
                        Name = "Desserts",
                        Description = "Recettes sucrées pour terminer un repas."
                    },
                    new Category
                    {
                        Name = "Plats Principaux",
                        Description = "Recettes pour le plat principal d'un repas."
                    },
                    new Category
                    {
                        Name = "Entrées Chaudes",
                        Description = "Recettes d'entrées servies chaudes."
                    },
                    new Category
                    {
                        Name = "Entrées Froides",
                        Description = "Recettes d'entrées servies froides."
                    },
                    new Category
                    {
                        Name = "Boissons Chaudes",
                        Description = "Recettes de boissons servies chaudes."
                    },
                    new Category
                    {
                        Name = "Boissons Froides",
                        Description = "Recettes de boissons servies froides."
                    }
                );
                SaveChanges();
            }
        }
    }
}