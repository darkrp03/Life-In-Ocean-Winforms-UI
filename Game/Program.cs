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
            var helperForm = new HelperForm();
            var settingsForm = new SettingsForm(ocean);
            var gameForm = new GameForm(ocean);
            var menuForm = new MenuForm();

            var oceanController = new OceanController(ocean);     
            var settingFormController = new SettingsFormController(settingsForm, oceanController, ocean);        
            var gameFormController = new GameFormController(gameForm, menuForm, ocean, oceanController);        
            var menuFormController = new MenuFormController(menuForm, gameForm, settingsForm, helperForm);

            Application.Run(menuForm);
        }
    }
}
