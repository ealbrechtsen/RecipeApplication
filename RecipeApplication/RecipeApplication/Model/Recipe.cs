using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication.Model
{
    public class Recipe
    {
        private string name;
        private string instruction;

        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
       
        public string Instruction
        {
            get { return instruction; }
            set { instruction = value; }
        }
    }
}
