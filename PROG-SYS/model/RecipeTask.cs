using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    class RecipeTask
    {
        public string name { get; set; }
        public int duration { get; set; }
        public (HallEntity, int) material { get; set; }

        public RecipeTask(string name, int duration, (HallEntity, int) material)
        {
            this.name = name;
            this.duration = duration;
            this.material = material;
        }
    }
}
