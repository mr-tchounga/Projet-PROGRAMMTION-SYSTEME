using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_PROG_SYS.model
{
    class HallModel
    {
        public HallRoom hallRoom { get; set; }

        public (HallEntity, int) door;

        public (HallEntity, int) table;

        public (HallEntity, int) chair;

        public (HallEntity, int) plate;

        public (HallEntity, int) cover;

        public (HallEntity, int) glass;

        public (HallEntity, int) bottle;

        public (HallEntity, int) basket;

        public Command[] commands { get; set; }

        public HallElementMobileStaffButler butlers { get; set; }

        public HallElementMobileStaffHeadWaiter headWaiter { get; set; }

        public HallElementMobileStaffWaiter[] waiter { get; set; }

        public HallElementMobileStaffClerk clerk { get; set; }

        public HallElementMobileStaffClient[] client { get; set; }


        public HallModel()
        {
            hallRoom = new HallRoom();

            door = (HallEntityFactory.CreateDoor(), 5);
            table = (HallEntityFactory.CreateTable(), 5);
            chair = (HallEntityFactory.CreateChair(), 5);
            plate = (HallEntityFactory.CreatePlate(), 5);
            cover = (HallEntityFactory.CreateCover(), 5);
            glass = (HallEntityFactory.CreateGlass(), 5);
            bottle = (HallEntityFactory.CreateBottle(), 5);
            basket = (HallEntityFactory.CreateBasket(), 5);

            commands = new Command[1]
            {
                new Command(
                    1,
                    new Recipe[2]
                    {
                        new Recipe("Corn-tchaff", "corn", "pot"),
                        new Recipe("Tenue militaire", "red-oil", "bowl")
                    }
                )
            };

            butlers = HallElementMobileStaffFactory.CreateButler();
            headWaiter = HallElementMobileStaffFactory.CreateHeadWaiter();
            waiter = new HallElementMobileStaffWaiter[2];
            clerk = HallElementMobileStaffFactory.CreateClerk();
            client = new HallElementMobileStaffClient[20];

            for (int  i=0; i<waiter.Length; i++)
            {
                waiter[i] = HallElementMobileStaffFactory.CreateWaiter();
            }

            for (int  i=0; i<client.Length; i++)
            {
                client[i] = HallElementMobileStaffFactory.CreateClient();
            }
        }
    }
}
