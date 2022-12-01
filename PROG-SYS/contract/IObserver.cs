using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.contract
{
    internal interface IObservers
    {
        void UpdateHasMoved(int x, int y, int newX, int newY);
    }
}
