using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_PROG_SYS.contract;

namespace Proj_PROG_SYS.model
{
    internal class HallElementMobileStaffFactory
    {
        private static HallElementMobileStaffButler BUTLER = new HallElementMobileStaffButler();
        private static HallElementMobileStaffHeadWaiter HEADWAITER = new HallElementMobileStaffHeadWaiter();
        private static HallElementMobileStaffWaiter WAITER = new HallElementMobileStaffWaiter();
        private static HallElementMobileStaffClerk CLERK = new HallElementMobileStaffClerk();
        private static HallElementMobileStaffClient CLIENT = new HallElementMobileStaffClient();

        public static HallElementMobileStaffButler CreateButler()
        {
            return BUTLER;
        }

        public static HallElementMobileStaffHeadWaiter CreateHeadWaiter()
        {
            return HEADWAITER;
        }

        public static HallElementMobileStaffWaiter CreateWaiter()
        {
            return WAITER;
        }

        public static HallElementMobileStaffClerk CreateClerk()
        {
            return CLERK;
        }

        public static HallElementMobileStaffClient CreateClient()
        {
            return CLIENT;
        }

    }
}
