using RecipeApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication.ViewModel
{
    class RecipeRepository
    {
        private List<Recipe> recipes = new List<Recipe>();
         
        public void AddRecipe (Recipe recipe)
        {
            recipes.Add(recipe);
        } 

    }
}
