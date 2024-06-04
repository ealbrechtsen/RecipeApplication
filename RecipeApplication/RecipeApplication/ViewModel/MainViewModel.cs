using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeApplication.Model;

namespace RecipeApplication.ViewModel
{
    public class MainViewModel
    {

        public ObservableCollection<RecipeVM> recipeVMs { get; set; }
    }
}
