using RecipeNotebook.Data.Context;
using RecipeNotebook.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RecipeNotebook.Data.Repositories
{
    public class RecipeRepository
    {
        private readonly RecipeContext _context;
        public RecipeRepository(RecipeContext context)
        {
            _context = context;
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _context.Recipes.ToList();
        }

        public Recipe GetById(int id)
        {
            return _context.Recipes.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Recipe recipe)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == recipe.Category.Id);
            recipe.Category = category;
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void Update(Recipe recipe)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == recipe.Category.Id);
            recipe.Category = category;
            _context.Recipes.Update(recipe);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var recipe = _context.Recipes.Find(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
                _context.SaveChanges();
            }
        }
    }
}
