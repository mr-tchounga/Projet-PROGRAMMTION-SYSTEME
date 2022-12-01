using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_PROG_SYS.contract;

namespace Proj_PROG_SYS.model
{
    internal abstract class HallElementMobile : HallElement
    {
        public string name { get; set; }

        private List<IObservers> observers;
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }

        public HallElementMobile()
        {
            observers = new List<IObservers>();
            speed = 3;
        }

        //public HallElementMobile(string name) : base(name)
        //{
        //    this.name = name;
        //}


        public void MoveUp()
        {
            y -= speed;
        }

        public void MoveDown()
        {
            y += speed;
        }

        public void MoveLeft()
        {
            x -= speed;
        }

        public void MoveRight()
        {
            x += speed;
        }

        public void AddObserver(IObservers observers)
        {
            observers.Add(observers);
        }

        public void NotifyHasMoved(int x, int y, int newX, int newY)
        {
            foreach (IObservers observer in observers)
            {
                observer.UpdateHasMoved(x, y, newX, newY);
            }
        }

        public abstract void Start();

    }
}
