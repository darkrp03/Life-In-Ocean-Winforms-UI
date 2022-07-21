using Game.Controllers;
using Game.Views;
using OceanLogic;
using OceanLogic.Controllers;
using System;
using System.Windows.Forms;

namespace Game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var ocean = new Ocean();
            var oceanController = new OceanController(ocean);

            var menuForm = new MenuForm();
            var menuFormController = new MenuFormController(menuForm, ocean, oceanController);

            Application.Run(menuForm);
        }
    }
}
