using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook.Data.Context;
using RecipeNotebook.Data.Repositories;

namespace RecipeNotebook.Data
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Enregistrer RecipeContext avec les options SQLite et initialiser la base de données avec des données de test
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRecipeNotebookDataService(this IServiceCollection services)
        {
            services.AddDbContext<RecipeContext>(options =>
            {
                options.UseSqlite("Data Source=recipes.db");
                // Utiliser Seeding pour initialiser la base de données avec des données de test
                options.UseSeeding((context, _) =>
                {
                    (context as RecipeContext).Seed();
                });
            }
            // Utiliser Transient pour éviter les problèmes de scope dans winforms
            , ServiceLifetime.Transient
            );

            // Enregistrer les repositories
            services.AddTransient<CategoryRepository>();
            services.AddTransient<RecipeRepository>();

            return services;
        }

        /// <summary>
        /// Appliquer les migrations au démarrage
        /// </summary>
        /// <param name="services"></param>
        public static void ApplyMigrationsForRecipeNotebookDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<RecipeContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
}
