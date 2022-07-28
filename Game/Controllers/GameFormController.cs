using Game.Views;
using OceanLogic;
using OceanLogic.Controllers;
using OceanLogic.Interfaces;
using System;
using System.Windows.Forms;

namespace Game.Controllers
{
    internal class GameFormController
    {
        #region Fields    
        private readonly IOceanViewer _ocean; //Object for getting information from business logic
        private readonly MenuForm _menuForm; //Object for manage menu form
        private readonly GameForm _gameForm; //Object for maange game form
        private readonly OceanController _oceanController; //Controller for manage business logic  
        private int _numIterations = 0; //Current numeric iteration
        #endregion

        #region Ctor       
        public GameFormController(GameForm gameForm, MenuForm menuForm, IOceanViewer ocean, OceanController oceanController)
        {
            _gameForm = gameForm;
            _gameForm.VisibleChanged += GameForm_VisibilityChanged;
            _gameForm.FormClosing += GameForm_FormClosing;
            _gameForm.GameTimer.Tick += Timer_Tick;
            _gameForm.KeyPress += KeyPressed;
            _gameForm.ButtonStop.Click += StopButton_Click;
            _gameForm.ButtonContinue.Click += ContinueButton_Click;
            _gameForm.ButtonSpeakerOn_Click = ButtonSpeakerOn_Click;
            _gameForm.ButtonSpeakerOff_Click = ButtonSpeakerOff_Click;
            _gameForm.ButtonNextMusic.Click += ButtonNextMusic_Click;
            _gameForm.ButtonPreviousMusic.Click += ButtonPreviousMusic_Click;
            _gameForm.ButtonBack.Click += BackButton_Click;
            _gameForm.ButtonResetGame.Click += ResetGameButton_Click;

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

        private void StartGame()
        {
            _gameForm.DisplayInitialText();
            _gameForm.GameTimer.Enabled = true;

            _oceanController.GenerateObjects();
            GenerateTable();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (_numIterations++ == _ocean.NumIterations)
            {
                _gameForm.GameTimer.Enabled = false;
            }
            else
            {
                _gameForm.DisplayGameField();
                
                (int, int, int) settings = _gameForm.DisplayAndGetStats(_numIterations);

                _oceanController.SetSettings(settings.Item1, settings.Item2, settings.Item3);
                _oceanController.Process();
            }
        }

        private void PreyOrPredatorsDied() //Method is executed when prey or predators have died
        {
            _gameForm.GameTimer.Enabled = false;

            _gameForm.ButtonStop.Enabled = false;
            _gameForm.ButtonResetGame.Enabled = true;
            _gameForm.ButtonBack.Enabled = true;

            MessageBox.Show("Game Over", "Notification");         
        }

        private void ContinueButton_Click(object? sender, EventArgs e)
        {
            _gameForm.ButtonContinue.Enabled = false;
            _gameForm.ButtonContinue.Hide();
                        
            _gameForm.ButtonStop.Show();
            _gameForm.ButtonStop.Enabled = true;

            _gameForm.ButtonResetGame.Enabled = false;
            _gameForm.ButtonBack.Enabled = false;

            _gameForm.GameTimer.Enabled = true;
        }

        private void StopButton_Click(object? sender, EventArgs e)
        {
            _gameForm.ButtonStop.Enabled = false;
            _gameForm.ButtonStop.Hide();

            _gameForm.ButtonContinue.Show();
            _gameForm.ButtonContinue.Enabled = true;

            _gameForm.ButtonResetGame.Enabled = true;
            _gameForm.ButtonBack.Enabled = true;

            _gameForm.GameTimer.Enabled = false;
        }

        private void ButtonSpeakerOn_Click(object? sender, EventArgs e)
        {
            SoundService.SoundPlayer.Stop();
            SoundService.IsMuted = true;

            _gameForm.ButtonNextMusic.Enabled = false;
            _gameForm.ButtonPreviousMusic.Enabled = false;

            _gameForm.DisableButtonSpeaker();
            _menuForm.DisableButtonSpeaker();
        }

        private void ButtonSpeakerOff_Click(object? sender, EventArgs e)
        {
            SoundService.SoundPlayer.PlayLooping();
            SoundService.IsMuted = false;

            _gameForm.ButtonNextMusic.Enabled = true;
            _gameForm.ButtonPreviousMusic.Enabled = true;

            _gameForm.EnableButtonSpeaker();
            _menuForm.EnableButtonSpeaker();
        }

        private void ButtonNextMusic_Click(object? sender, EventArgs e)
        {
            SoundService.SoundPlayer.Stop();
            SoundService.SetNextMusic();
            SoundService.SoundPlayer.PlayLooping();
        }

        private void ButtonPreviousMusic_Click(object? sender, EventArgs e)
        {
            SoundService.SoundPlayer.Stop();
            SoundService.SetPreviousMusic();
            SoundService.SoundPlayer.PlayLooping();
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            _gameForm.ButtonContinue.Enabled = false;
            _gameForm.ButtonContinue.Hide();

            _gameForm.ButtonStop.Show();
            _gameForm.ButtonStop.Enabled = true;

            _gameForm.ButtonResetGame.Enabled = false;
            _gameForm.ButtonBack.Enabled = false;

            _oceanController.ResetGame();

            _gameForm.GameField.Rows.Clear();
            _gameForm.GameField.Columns.Clear();

            _gameForm.Hide();
            _menuForm.Show();

            SoundService.SoundPlayer.Stop();
            SoundService.SoundPlayer.SoundLocation = GameSettings.menuSongPath;

            if (!SoundService.IsMuted)
            {
                SoundService.SoundPlayer.PlayLooping();
            }
        }

        private void ResetGameButton_Click(object? sender, EventArgs e)
        {
            _numIterations = 0;

            _oceanController.ResetGame();

            _gameForm.GameField.Rows.Clear();
            _gameForm.GameField.Columns.Clear();

            _gameForm.ButtonContinue.Enabled = false;
            _gameForm.ButtonContinue.Hide();

            _gameForm.ButtonStop.Show();
            _gameForm.ButtonStop.Enabled = true;

            _gameForm.ButtonBack.Enabled = false;
            _gameForm.ButtonResetGame.Enabled = false;

            if (!SoundService.IsMuted)
            {
                SoundService.SoundPlayer.Stop();
                SoundService.SetNextMusic();
                SoundService.SoundPlayer.PlayLooping();
            }

            StartGame();
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

        private void GameForm_VisibilityChanged(object? sender, EventArgs e)
        {
            if (_gameForm.Visible)
            {
                SoundService.SetDefaultMusic();

                if (!SoundService.IsMuted)
                {             
                    SoundService.SoundPlayer.Play();
                }

                StartGame();
            }
        }

        private void GameForm_FormClosing(object? sender, FormClosingEventArgs e) => Environment.Exit(0);
        #endregion
    }
}
