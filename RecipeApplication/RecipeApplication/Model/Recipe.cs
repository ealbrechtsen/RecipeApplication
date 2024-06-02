using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication.Model
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Recipe(int recipeId, string name, string description)
        {
            RecipeId = recipeId;
            Name = name;
            Description = description;
        }
    }
}
