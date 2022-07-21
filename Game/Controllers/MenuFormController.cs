using Game.Views;
using OceanLogic.Controllers;
using OceanLogic.Interfaces;
using System;

namespace Game.Controllers
{
    internal class MenuFormController
    {
        #region Fields
        private readonly IOceanViewer _ocean;
        private readonly MenuForm _menuForm;       
        private readonly OceanController _oceanController;
        private readonly GameForm _gameForm;
        private readonly GameFormController _gameFormController;
        private readonly SettingsForm _settingsForm;
        private readonly SettingsFormController _settingFormController;
        #endregion

        #region Ctor        
        public MenuFormController(MenuForm menuForm, IOceanViewer ocean, OceanController oceanController)
        {
            _menuForm = menuForm;
            _menuForm.PlayButton.Click += PlayButtonClick;
            _menuForm.SettingsButton.Click += SettingsButtonClick;
            _menuForm.ExitButton.Click += ExitButtonClick;

            _ocean = ocean;
            _oceanController = oceanController;

            _gameForm = new GameForm(_ocean);
            _gameFormController = new GameFormController(_gameForm, _menuForm, _ocean, _oceanController);

            _settingsForm = new SettingsForm(_ocean);
            _settingFormController = new SettingsFormController(_settingsForm, _oceanController, _ocean);
        }
        #endregion

        #region Methods        
        private void PlayButtonClick(object? sender, EventArgs args)
        {
            _gameForm.Show();
            _menuForm.Hide();
        }

        private void SettingsButtonClick(object? sender, EventArgs args) => _settingsForm.ShowDialog();

        private void ExitButtonClick(object? sender, EventArgs args) => Environment.Exit(0);
        #endregion
    }
}
