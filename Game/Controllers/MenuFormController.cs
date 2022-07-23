using Game.Views;
using OceanLogic;
using System;

namespace Game.Controllers
{
    internal class MenuFormController
    {
        #region Fields
        private readonly MenuForm _menuForm; //Object for manage menu form    
        private readonly GameForm _gameForm; //Object for manage game form
        private readonly SettingsForm _settingsForm; //Object for manage settings form
        #endregion

        #region Ctor        
        public MenuFormController(MenuForm menuForm, GameForm gameForm, SettingsForm settingsForm)
        {
            _menuForm = menuForm;
            _menuForm.ButtonPlay_Click = PlayButton_Click;
            _menuForm.ButtonSettings_Click = SettingsButton_Click;
            _menuForm.ButtonSpeakerOn_Click = ButtonSpeakerOn_Click;
            _menuForm.ButtonSpeakerOff_Click = ButtonSpeakerOff_Click;
            _menuForm.ButtonExit_Click = ExitButtonClick;

            _gameForm = gameForm;

            _settingsForm = settingsForm;

            SoundService.SoundPlayer.SoundLocation = GameSettings.menuSongPath;
            SoundService.SoundPlayer.PlayLooping();
        }
        #endregion

        #region Methods  
        private void PlayButton_Click(object? sender, EventArgs args)
        {
            _gameForm.Show();
            _menuForm.Hide();
        }

        private void SettingsButton_Click(object? sender, EventArgs args) => _settingsForm.ShowDialog();    

        private void ButtonSpeakerOn_Click(object? sender, EventArgs args)
        {
            SoundService.SoundPlayer.Stop();
            SoundService.IsMuted = true;

            _menuForm.DisableButtonSpeaker();
            _gameForm.DisableButtonSpeaker();
        }

        private void ButtonSpeakerOff_Click(object? sender, EventArgs args)
        {
            SoundService.SoundPlayer.PlayLooping();
            SoundService.IsMuted = false;

            _menuForm.EnableButtonSpeaker();
            _gameForm.EnableButtonSpeaker();
        }

        private void ExitButtonClick(object? sender, EventArgs args) => Environment.Exit(0);
        #endregion
    }
}
