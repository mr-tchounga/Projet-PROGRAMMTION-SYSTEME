using Proj_PROG_SYS.contract;
using Proj_PROG_SYS.model;
using Proj_PROG_SYS.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Proj_PROG_SYS.controller
{
    internal class HallController
    {
        private static int TIME_SCALE = 1000;

        public HallModel model { get; set; }
        public HallView view{ get; set; }

        public Queue<(HallEntity, int)> receptionQueue{ get; set; }
        private static Mutex receptionQueue_ = new Mutex();
        private static ManualResetEvent receptionQueueMre = new ManualResetEvent(false);
        private static Mutex notifyrReceptionQueue_ = new Mutex();

        public Queue<Command> commandQueue{ get; set; }
        private static Mutex commandQueue_ = new Mutex();
        private static ManualResetEvent commandQueueMre = new ManualResetEvent(false);
        private static Mutex notifyCommandQueue_  = new Mutex();

        public Queue<Command> pendingCommandQueue{ get; set; }
        private static Mutex pendingCommandQueue_ = new Mutex();
        private static ManualResetEvent pendingCommandQueueMre = new ManualResetEvent(false);
        private static Mutex notifyPendingCommandQueue_ = new Mutex();

        public Queue<Command> doneCommandQueue{ get; set; }
        private static Mutex doneCommandQueue_ = new Mutex();
        private static ManualResetEvent doneCommandQueueMre = new ManualResetEvent(false);
        private static Mutex notifyDoneCommandQueue_ = new Mutex();


        public Queue<CommandTask> commandTaskQueue{ get; set; }
        private static Mutex commandTaskQueue_ = new Mutex();
        private static ManualResetEvent commandTaskQueueMre = new ManualResetEvent(false);
        private static Mutex notifyCommandTaskQueue_ = new Mutex();

        public Queue<Recipe> recipeQueue { get; set; }
        private static Mutex recipeQueue_ = new Mutex();
        private static ManualResetEvent recipeQueueMre = new ManualResetEvent(false);
        private static Mutex notifyRecipeQueue_ = new Mutex();

        public Queue<(HallEntity, int)> leavingQueue { get; set; }
        private static Mutex leavingQueue_ = new Mutex();
        private static ManualResetEvent leavingQueueMre = new ManualResetEvent(false);
        private static Mutex notifyleavingQueue_ = new Mutex();

        public Queue<RecipeTask> recipeTaskQueue { get; set; }
        private static Mutex recipeTaskQueue_ = new Mutex();
        private static ManualResetEvent recipeTaskQueueMre = new ManualResetEvent(false);
        private static Mutex notifyRecipeTaskQueue_ = new Mutex();


        public HallController(HallModel model, HallView view)
        {
            this.model = model;
            this.view = view;

            receptionQueue = new Queue<(HallEntity, int)>();
            commandQueue = new Queue<Command>();
            commandTaskQueue = new Queue<CommandTask>();
            pendingCommandQueue = new Queue<Command>();
            doneCommandQueue = new Queue<Command>();
            recipeQueue = new Queue<Recipe>(); 
            recipeTaskQueue = new Queue<RecipeTask>();
            leavingQueue = new Queue<(HallEntity, int)>();
        }


        public void start()
        {
            Thread butler = new Thread(new ThreadStart(ButlerTask));
            butler.Name = "Butler";
            butler.Start();
            model.butlers.AddObserver((IObservers)view);

            Thread headWaiter = new Thread(new ThreadStart(HeadWaiterTask));
            headWaiter.Name = "Head Waiter";
            headWaiter.Start();
            model.headWaiter.AddObserver((IObservers)view);

            for (int i=0; i<model.waiter.Length; i++)
            {
                Thread waiter = new Thread(new ThreadStart(HallWaiterTask));
                waiter.Name = "Waiter";
                waiter.Start();
            }

            Thread clerk = new Thread(new ThreadStart(ClerkTask));
            clerk.Name = "Head Waiter";
            clerk.Start();
            model.clerk.AddObserver((IObservers)view);

            for (int i = 0; i < model.client.Length; i++)
            {
                Thread client = new Thread(new ThreadStart(HallWaiterTask));
                client.Name = "Client";
                client.Start();
            }
        }
        

        private void ButlerTask()
        {
            while (true)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": Waiting for client");

                commandQueueMre.WaitOne();
                Console.WriteLine(Thread.CurrentThread.Name + ": client receptionned");

                commandQueue_.WaitOne();

                commandQueue_.ReleaseMutex();

                commandQueueMre.Reset();
            }
        }

        private void HeadWaiterTask()
        {
            while (true)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": Waiting for client...");
                notifyCommandQueue_.WaitOne();
                commandQueueMre.WaitOne();
                commandQueueMre.Reset();
                notifyCommandQueue_.ReleaseMutex();

                Console.WriteLine(Thread.CurrentThread.Name + ": client received.");

                commandQueue_.WaitOne();
                Recipe recipe = recipeQueue.First<Recipe>();
                recipeQueue.Dequeue();
                recipeQueue_.ReleaseMutex();

                
                Console.WriteLine(Thread.CurrentThread.Name + ": client sitted.");

            }
        }

        private void HallWaiterTask()
        {
            while (true)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": Waiting for Recipe...");
                notifyCommandQueue_.WaitOne();
                recipeQueueMre.WaitOne();
                recipeQueueMre.Reset();
                notifyCommandQueue_.ReleaseMutex();

                Console.WriteLine(Thread.CurrentThread.Name + ": Recipe received.");

                recipeQueue_.WaitOne();
                Recipe recipe = recipeQueue.First<Recipe>();
                recipeQueue.Dequeue();
                recipeQueue_.ReleaseMutex();


                foreach (RecipeTask task in recipe.recipeTasks)
                {
                    while (task.material.Item2 == 0)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + ": Waiting for " + task.material.Item1.name);
                        Thread.Sleep(2000);

                    }
                    task.material = (task.material.Item1, task.material.Item2 - 1);
                    Console.WriteLine(Thread.CurrentThread.Name + ": Doing task '" + task.name + "' ...");
                    Thread.Sleep(task.duration * TIME_SCALE);
                    Console.WriteLine(Thread.CurrentThread.Name + ": Task '" + task.name + "' done.");

                    leavingQueue_.WaitOne();
                    leavingQueue.Enqueue(task.material);
                    leavingQueueMre.Set();
                    leavingQueue_.ReleaseMutex();
                }

                Console.WriteLine(Thread.CurrentThread.Name + ": Recipe '" + recipe.name + "' done.");


                doneCommandQueue_.WaitOne();
                pendingCommandQueue_.WaitOne();
                doneCommandQueue.Enqueue(pendingCommandQueue.First<Command>());
                doneCommandQueueMre.Set();
                pendingCommandQueue_.ReleaseMutex();
                doneCommandQueue_.ReleaseMutex();
            }
        }
        
        private void ClerkTask()
        {
            while (true)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": Waiting for done orders...");

                notifyDoneCommandQueue_.WaitOne();
                doneCommandQueueMre.WaitOne();
                doneCommandQueueMre.Reset();
                notifyDoneCommandQueue_.ReleaseMutex();

                Console.WriteLine(Thread.CurrentThread.Name + ": Done order received");

                doneCommandQueue_.WaitOne();
                Console.WriteLine(Thread.CurrentThread.Name + ": Moving'" + doneCommandQueue.First<Command>().recipes + "' to comptoir");
                doneCommandQueue.Dequeue();
                doneCommandQueue_.ReleaseMutex();
            }
        }
    }
}
