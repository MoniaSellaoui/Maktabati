using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook.Data;

namespace RecipeNotebook
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }


        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Enregistrer RecipeContext avec les options SQLite
            services.AddRecipeNotebookDataService();

            // Appliquer les migrations au démarrage
            services.ApplyMigrationsForRecipeNotebookDataService();



            // Initialisation de la configuration de l'application
            ApplicationConfiguration.Initialize();

            // Création d'une collection de services pour l'injection de dépendances
            //var services = new ServiceCollection();

            // Enregistrer les Forms
            services.RegisterForms();

            // Construction du fournisseur de services qui gère les instances des dépendances
            ServiceProvider = services.BuildServiceProvider();

            // Récupération de l'instance de la fenêtre principale via l'injection de dépendances
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();

            // Démarrage de l'application avec la fenêtre principale
            Application.Run(mainForm);
        }
    }
}