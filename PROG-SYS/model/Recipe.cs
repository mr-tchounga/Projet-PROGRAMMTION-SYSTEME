using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    internal class Recipe
    {
        public string name;
        public string ingredients { get; set; }
        public string recipeTasks { get; set; }

        public Recipe(string name, string ingredients, string recipeTasks)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.recipeTasks = recipeTasks;
        }
    }
}
