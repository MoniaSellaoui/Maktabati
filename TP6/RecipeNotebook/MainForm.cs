using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook.CategoryForms;

namespace RecipeNotebook
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private CategoryForms.CategoriesListForm _categoriesListForm;
        private RecipeForms.RecipesListForm _recipesListForm;
        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void recettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecipesListForm();
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCategoriesListForm();
        }


        //Private Methods
        private void ShowRecipesListForm()
        {
            //Vérifie si l'instance de la fenêtre des catégories est nulle ou déjà fermée
            if (_recipesListForm == null || _recipesListForm.IsDisposed)
            {
                // Récupère une instance via l'injection de dépendances
                _recipesListForm = _serviceProvider.GetRequiredService<RecipeForms.RecipesListForm>();
                // Définit la fenêtre comme enfant du formulaire MDI principal
                _recipesListForm.MdiParent = this;
                // Définit la fenêtre en plein écran
                _recipesListForm.WindowState = FormWindowState.Maximized;
            }
            // Affiche la fenêtre si elle n'est pas déjà affichée et la met au premier plan
            _recipesListForm.Show();
            _recipesListForm.Activate();
        }
        private void ShowCategoriesListForm()
        {
            // Vérifie si l'instance de la fenêtre des catégories est nulle ou déjà fermée
            if (_categoriesListForm == null || _categoriesListForm.IsDisposed)
            {
                // Récupère une instance via l'injection de dépendances
                _categoriesListForm = _serviceProvider.GetRequiredService<CategoryForms.CategoriesListForm>();
                // Définit la fenêtre comme enfant du formulaire MDI principal
                _categoriesListForm.MdiParent = this;
                // Définit la fenêtre en plein écran
                _categoriesListForm.WindowState = FormWindowState.Maximized;
            }

            // Affiche la fenêtre si elle n'est pas déjà affichée et la met au premier plan
            _categoriesListForm.Show();
            _categoriesListForm.Activate();
        }

    
    }
}
