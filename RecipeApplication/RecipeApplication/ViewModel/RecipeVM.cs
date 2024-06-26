﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeApplication.Model;

namespace RecipeApplication.ViewModel
{
    public class RecipeVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public RecipeVM(Recipe recipe) // parameterized constructor
        {
            Name = recipe.Name;
            Description = recipe.Description;
        }

    }
}
