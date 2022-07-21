using Game.Views;
using OceanLogic.Controllers;
using OceanLogic.Exceptions;
using OceanLogic.Interfaces;
using System;
using System.Drawing;

namespace Game.Controllers
{
    internal class SettingsFormController
    {
        #region Fields     
        private readonly IOceanViewer _ocean;
        private readonly SettingsForm _settingsForm;
        private readonly OceanController _oceanController;     
        #endregion

        #region Ctor       
        public SettingsFormController(SettingsForm settingsForm, OceanController oceanController, IOceanViewer ocean)
        {
            _settingsForm = settingsForm;
            _settingsForm.ApplyButton.Click += ApplyButtonClick;
            _settingsForm.CancelButton.Click += CancelButtonClick;

            _oceanController = oceanController;

            _ocean = ocean;
        }
        #endregion

        #region Methods  

        private void ValidateData()
        {
            int numPrey = 0, numPredators = 0, numObstacles = 0, numIterations = 0;

            if (!Int32.TryParse(_settingsForm.AmoutOfPrey, out numPrey))
            {
                _settingsForm.WarningLabel.Show();
                return;
            }

            if (!Int32.TryParse(_settingsForm.AmoutOfPredators, out numPredators))
            {
                _settingsForm.WarningLabel.Show();
                return;
            }

            if (!Int32.TryParse(_settingsForm.AmoutOfObstacles, out numObstacles))
            {
                _settingsForm.WarningLabel.Show();
                return;
            }

            if (!Int32.TryParse(_settingsForm.AmoutOfIterations, out numIterations))
            {
                _settingsForm.WarningLabel.Show();
                return;
            }

            if (numPrey + numPredators + numObstacles >= _ocean.NumRows * _ocean.NumColumns)
            {
                throw new GameFieldOverfillingException();
            }

            _oceanController.SetSettings(numPrey, numPredators, numObstacles, numIterations);
        }

        private void ApplyButtonClick(object? sender, EventArgs args) //Method when user press "Apply" button
        {
            _settingsForm.WarningLabel.Hide();

            try
            {
                ValidateData();
                _settingsForm.WarningLabel.Hide();
            }
            catch (GameFieldOverfillingException e)
            {
                _settingsForm.WarningLabel.Text = e.Message;
                _settingsForm.WarningLabel.Show();
            }
        }

        private void CancelButtonClick(object? sender, EventArgs args) => _settingsForm.Hide(); //Method when user press "Cancel" button
        #endregion
    }
}
