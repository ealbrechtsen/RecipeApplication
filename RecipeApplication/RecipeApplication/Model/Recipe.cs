using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication.Model
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Recipe(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
