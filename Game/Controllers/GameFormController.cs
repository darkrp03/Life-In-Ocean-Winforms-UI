using Game.Views;
using OceanLogic.Controllers;
using OceanLogic.Interfaces;
using System;
using System.Windows.Forms;

namespace Game.Controllers
{
    internal class GameFormController
    {
        #region Fields    
        private readonly IOceanViewer _ocean;
        private readonly MenuForm _menuForm;
        private readonly GameForm _gameForm;
        private readonly OceanController _oceanController;     
        private int _numIterations = 0;
        private string text = string.Empty;
        #endregion

        #region Ctor       
        public GameFormController(GameForm gameForm, MenuForm menuForm, IOceanViewer ocean, OceanController oceanController)
        {
            _gameForm = gameForm;
            _gameForm.Load += GameForm_Load;
            _gameForm.FormClosing += GameForm_FormClosing;
            _gameForm.GameTimer.Tick += TimerTick;
            _gameForm.KeyPress += KeyPressed;
            _gameForm.StopButton.Click += StopButtonClick;
            _gameForm.ContinueButton.Click += ContinueButtonClick;
            _gameForm.BackButton.Click += BackButtonClick;

            _ocean = ocean;

            _oceanController = oceanController;
            _oceanController.OnPreyOrPredatorsDied += PreyOrPredatorsDied;

            _menuForm = menuForm;
        }
        #endregion

        #region Methods       
        private void GenerateTable() //Create table
        {
            for (int i = 0; i < _ocean.NumColumns; i++)
            {
                var imageColumn = new DataGridViewImageColumn();
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageColumn.DefaultCellStyle.NullValue = null;

                _gameForm.GameField.Columns.Add(imageColumn);
                _gameForm.GameField.Columns[i].Width = 25;
            }

            for (int i = 0; i < _ocean.NumRows; i++)
            {
                _gameForm.GameField.Rows.Add();
                _gameForm.GameField.Rows[i].Height = 40;
            }
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            if (_numIterations++ == _ocean.NumIterations)
            {
                _gameForm.GameTimer.Enabled = false;
            }
            else
            {
                _gameForm.DisplayCells();
                (int, int, int) settings = _gameForm.DisplayAndGetStats(_numIterations);

                _oceanController.SetSettings(settings.Item1, settings.Item2, settings.Item3);
                _oceanController.Process();
            }
        }

        private void PreyOrPredatorsDied()
        {
            _gameForm.GameTimer.Enabled = false;

            MessageBox.Show("Game Over", "Notification");         
        }

        private void ContinueButtonClick(object? sender, EventArgs e)
        {
            _gameForm.ContinueButton.Enabled = false;
            _gameForm.ContinueButton.Hide();

            _gameForm.StopButton.Enabled = true;
            _gameForm.ResetGameButton.Enabled = true;

            _gameForm.BackButton.Enabled = false;

            _gameForm.GameTimer.Enabled = true;
        }

        private void StopButtonClick(object? sender, EventArgs e)
        {
            _gameForm.ContinueButton.Show();
            _gameForm.ContinueButton.Enabled = true;

            _gameForm.StopButton.Enabled = false;

            _gameForm.BackButton.Enabled = true;

            _gameForm.GameTimer.Enabled = false;
        }

        private void BackButtonClick(object? sender, EventArgs e)
        {
            _gameForm.Hide();
            _menuForm.Show();
        }

        private void KeyPressed(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.P || e.KeyChar == char.ToLower((char)Keys.P))
            {
                if (_gameForm.GameTimer.Enabled)
                {
                    _gameForm.GameTimer.Enabled = false;
                }
                else
                {
                    _gameForm.GameTimer.Enabled = true;
                }
            }
        }

        private void GameForm_Load(object? sender, EventArgs e)
        {
            _gameForm.DisplayInitialText();
            _gameForm.GameTimer.Enabled = true;

            _oceanController.GenerateObjects();
            GenerateTable();

            _gameForm.DisplayCells();
        }

        private void GameForm_FormClosing(object? sender, FormClosingEventArgs e) => Environment.Exit(0);
        #endregion
    }
}
