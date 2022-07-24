using Game.Views;
using OceanLogic.Controllers;
using OceanLogic.Exceptions;
using OceanLogic.Interfaces;
using System;

namespace Game.Controllers
{
    internal class SettingsFormController
    {
        #region Fields     
        private readonly IOceanViewer _ocean; //Object for getting information from business logic
        private readonly SettingsForm _settingsForm; //Object for manage settings form
        private readonly OceanController _oceanController; //Object for manage business logic  
        #endregion

        #region Ctor       
        public SettingsFormController(SettingsForm settingsForm, OceanController oceanController, IOceanViewer ocean)
        {
            _settingsForm = settingsForm;
            _settingsForm.ButtonApply_Click = ButtonApply_Click;
            _settingsForm.ButtonCancel_Click = ButtonCancel_Click;

            _oceanController = oceanController;

            _ocean = ocean;
        }
        #endregion

        #region Methods  
        private void ValidateData()
        {
            int numPrey = 0, numPredators = 0, numObstacles = 0, numKillerWhales = 0, numIterations = 0;

            if (!Int32.TryParse(_settingsForm.AmoutOfPrey, out numPrey))
            {
                _settingsForm.LabelWarning.Show();
                return;
            }

            if (!Int32.TryParse(_settingsForm.AmoutOfPredators, out numPredators))
            {
                _settingsForm.LabelWarning.Show();
                return;
            }

            if (!Int32.TryParse(_settingsForm.AmountOfKillerWhales, out numKillerWhales))
            {
                _settingsForm.LabelWarning.Show();
                return;
            }

            if (!Int32.TryParse(_settingsForm.AmoutOfObstacles, out numObstacles))
            {
                _settingsForm.LabelWarning.Show();
                return;
            }
          
            if (!Int32.TryParse(_settingsForm.AmoutOfIterations, out numIterations))
            {
                _settingsForm.LabelWarning.Show();
                return;
            }

            if (numPrey + numPredators + numObstacles + numKillerWhales >= _ocean.NumRows * _ocean.NumColumns)
            {
                throw new GameFieldOverfillingException();
            }

            _oceanController.SetSettings(numPrey, numPredators, numKillerWhales, numObstacles, numIterations);
        }

        private void ButtonApply_Click(object? sender, EventArgs args) 
        {
            _settingsForm.LabelWarning.Hide();

            try
            {
                ValidateData();
            }
            catch (GameFieldOverfillingException e)
            {
                _settingsForm.LabelWarning.Text = e.Message;
                _settingsForm.LabelWarning.Show();
            }
        }

        private void ButtonCancel_Click(object? sender, EventArgs args)
        {
            _settingsForm.SetDefaultTextBoxValue();
            _settingsForm.Hide();
        }
        #endregion
    }
}
