using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    internal class Command
    {
        public int idTable { get; set; }
        public Recipe[] recipes { get; set; }

        public Command(int idTable, Recipe[] recipe)
        {
            this.idTable = idTable;
            this.recipes = recipe;
        }
    }
}
