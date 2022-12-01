using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    class CommandTask
    {
        public (HallEntity, int) entity { get; set; }
        public DateTime commandDate { get; set; }
        public int duration { get; set; }

        public CommandTask((HallEntity, int) entity, DateTime commandDate)
        {
            this.entity = entity;
            this.commandDate = commandDate;
        }

        public CommandTask((HallEntity, int) entity, DateTime commandDate, int duration)
        {
            this.entity = entity;
            this.commandDate = commandDate;
            this.duration = duration;
        }

    }
}
