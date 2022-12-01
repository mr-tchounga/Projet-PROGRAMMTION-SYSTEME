using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    internal class HallElementMobileStaffButler : HallElementMobileStaff
    {
        public HallElementMobileStaffButler()
        {
            x = 10;
            y = 100;
            sprite = Image.FromFile(@"");
        }

        public override void Start()
        {
            //while (true)
            //{
            //    int pastX = x;
            //    int pastY = y;
            //    MoveRight();
            //    NotifyHasMoved(pastX, pastY, x, y);
            //}
        }
    }
}
