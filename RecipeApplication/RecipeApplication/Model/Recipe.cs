using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication.Model
{
    public class Recipe
    {
        #region properties

        // fully implemented properties
        private string name;
        private string instruction;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Instruction
        {
            get { return instruction; }
            set { instruction = value; }
        }
        #endregion

        #region Constructors
        public Recipe()
        {

        }

        public Recipe(string name)
        {
            Name = name;
        }

        public Recipe(string name, string instruction)
        {
            Name = name;
            Instruction = instruction;
        }
        #endregion
    }
}
