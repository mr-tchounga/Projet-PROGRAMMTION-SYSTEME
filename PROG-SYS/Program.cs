using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_PROG_SYS.controller;
using Proj_PROG_SYS.model;
using Proj_PROG_SYS.view;

using PROG_SYS.View;

namespace PROG_SYS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());

            HallModel model = new HallModel();
            HallView view = new HallView();
            HallController controller = new HallController(model, view);

            controller.start();

        }
    }
}
