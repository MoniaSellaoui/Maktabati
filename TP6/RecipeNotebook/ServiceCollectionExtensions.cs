using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeNotebook
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterForms(this IServiceCollection services)
        {
            services.AddTransient<MainForm>();
            services.AddTransient<CategoryForms.CategoriesListForm>();
            services.AddTransient<CategoryForms.CategoryDetailsForm>();
            services.AddTransient<RecipeForms.RecipesListForm>();
            services.AddTransient<RecipeForms.RecipeDetailsForm>();
        }
    }
}
