using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    internal class HallEntityFactory
    {
        private static HallEntity DOOR = new HallEntity("door");
        private static HallEntity TABLE = new HallEntity("table");
        private static HallEntity CHAIR = new HallEntity("chair");
        private static HallEntity PLATE = new HallEntity("plate");
        private static HallEntity COVER = new HallEntity("cover");
        private static HallEntity GLASS = new HallEntity("glass");
        private static HallEntity BOTTLE = new HallEntity("bottle");
        private static HallEntity BASKET = new HallEntity("basket");

        public static HallEntity CreateDoor()
        {
            return DOOR;
        }

        public static HallEntity CreateTable()
        {
            return TABLE;
        }

        public static HallEntity CreateChair()
        {
            return CHAIR;
        }

        public static HallEntity CreatePlate()
        {
            return PLATE;
        }

        public static HallEntity CreateCover()
        {
            return COVER;
        }

        public static HallEntity CreateGlass()
        {
            return GLASS;
        }

        public static HallEntity CreateBottle()
        {
            return BOTTLE;
        }

        public static HallEntity CreateBasket()
        {
            return BASKET;
        }
    }
}
