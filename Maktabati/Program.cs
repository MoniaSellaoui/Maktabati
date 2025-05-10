

namespace Maktabati
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            // Activer le visualiseur de compatibilité pour les applications Windows Forms  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Initialiser la culture de l'application  
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
            {
                // Initialisation de la configuration de l'application  
                ApplicationConfiguration.Initialize();

                // Assurez-vous que la base de données est créée  
                var factory = new BibliothequeContextFactory();
                using (var context = factory.CreateDbContext(new string[0]))
                {
                    context.Database.EnsureCreated();
                }

                // Lancer l'application avec le formulaire principal  
                Application.Run(new MainForm()); // Correction de la parenthèse manquante  
            }
        }
    }
}