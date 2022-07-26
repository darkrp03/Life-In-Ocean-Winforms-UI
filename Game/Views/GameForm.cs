﻿using OceanLogic;
using OceanLogic.GameObjects;
using OceanLogic.Interfaces;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class GameForm : Form
    {
        #region Fields
        private readonly IOceanViewer _ocean; //Objedct for getting information from business logic
        private readonly Bitmap _preyImage; //Object with fish image 
        private readonly Bitmap _predatorImage; //Object with shark image
        private readonly Bitmap _killerWhaleImage; //Object with killer whale image
        private readonly Bitmap _obstacleImage; //Object with obstacle image
        #endregion

        #region Ctor       
        public GameForm(IOceanViewer ocean)
        {
            InitializeComponent();
            DoubleBuffered(true);

            MaximizeBox = false;
            BackgroundImageLayout = ImageLayout.Stretch;
            WindowState = FormWindowState.Maximized;

            navigationPanel.BackColor = Color.FromArgb(120, Color.Black);

            _preyImage = new Bitmap(GameSettings.preyImagePath);
            _predatorImage = new Bitmap(GameSettings.predatorImagePath);
            _killerWhaleImage = new Bitmap(GameSettings.killerWhaleImagePath);
            _obstacleImage = new Bitmap(GameSettings.obstacleImagePath);

            _ocean = ocean;
        }
        #endregion

        #region Properties 
        public DataGridView GameField
        {
            get => gameField;
        }

        public Timer GameTimer
        {
            get => gameTimer;
        }

        public Button ButtonContinue
        {
            get => buttonContinue;
        }

        public Button ButtonStop
        {
            get => buttonStop;
        }
        public Button ButtonNextMusic
        {
            get => buttonNextMusic;
        }

        public Button ButtonPreviousMusic
        {
            get => buttonPreviousMusic;
        }

        public Button ButtonBack
        {
            get => buttonBack;
        }

        public Button ButtonResetGame
        {
            get => buttonResetGame;
        }

        public EventHandler ButtonSpeakerOn_Click
        {
            set => buttonSpeakerOn.Click += value;
        }

        public EventHandler ButtonSpeakerOff_Click
        {
            set => buttonSpeakerOff.Click += value;
        }      
        #endregion

        #region Methods      
        private new void DoubleBuffered(bool enabled) //Enable double buffered for DatagridView
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            gameField, new object[] { enabled });
        }        

        /// <summary>
        /// Enables "buttonSpeakerOn".
        /// </summary>
        public void EnableButtonSpeaker()
        {
            buttonSpeakerOn.Show();
            buttonSpeakerOn.Enabled = true;

            buttonSpeakerOff.Enabled = false;
            buttonSpeakerOff.Hide();
        }

        /// <summary>
        /// Disables "buttonSpeakerOn".
        /// </summary>
        public void DisableButtonSpeaker()
        {
            buttonSpeakerOn.Enabled = false;
            buttonSpeakerOn.Hide();

            buttonSpeakerOff.Enabled = true;
            buttonSpeakerOff.Show();
        }

        /// <summary>
        /// Displays text when the form is loaded.
        /// </summary>
        public void DisplayInitialText()
        {
            labelInfo.Text = $"Iterations: 0  Prey: {_ocean.NumPrey}  Predators: {_ocean.NumPredators}  Killer Whales: {_ocean.NumKillerWhales}  Obstacles: {_ocean.NumObstacles}    ";
        }

        /// <summary>
        /// Displays dataGridView table
        /// </summary>
        public void DisplayGameField() //Displays cells in table
        {
            for (int i = 0; i < _ocean.NumRows; i++)
            {
                for (int j = 0; j < _ocean.NumColumns; j++)
                {
                    var cell = _ocean.GetCellAt(i, j);

                    if (cell is not null)
                    {
                        if (cell is Fish)
                        {
                            gameField.Rows[i].Cells[j].Value = _preyImage;
                        }
                        if (cell is Shark)
                        {
                            gameField.Rows[i].Cells[j].Value = _predatorImage;
                        }
                        if (cell is Obstacle)
                        {
                            gameField.Rows[i].Cells[j].Value = _obstacleImage;
                        }
                        if (cell is KillerWhale)
                        {
                            gameField.Rows[i].Cells[j].Value = _killerWhaleImage;
                        }
                    }
                    else
                    {
                        gameField.Rows[i].Cells[j].Value = null;
                    }
                }
            }

            gameField.Refresh();
        }

        /// <summary>
        /// Displays and returns stats. 
        /// </summary>
        /// <param name="iteration">A numeric iteration</param>
        /// <returns>Tuple with 3 elements: numbers of prey, predators and obstacles</returns>
        public (int, int, int) DisplayAndGetStats(int iteration) //Displays and returns stats
        {
            int numPrey = 0, numPredators = 0, numObstacles = 0;

            for (int i = 0; i < _ocean.NumRows; i++)
            {
                for (int j = 0; j < _ocean.NumColumns; j++)
                {
                    if (gameField.Rows[i].Cells[j].Value == _preyImage)
                    {
                        numPrey++;
                    }
                    if (gameField.Rows[i].Cells[j].Value == _predatorImage)
                    {
                        numPredators++;
                    }
                    if (gameField.Rows[i].Cells[j].Value == _obstacleImage)
                    {
                        numObstacles++;
                    }
                }
            }
            labelInfo.Text = String.Format("Iterations: {0}  Fishes: {1}  Sharks: {2}  Killer Whales: {3}  Obstacles: {4}     ", iteration, numPrey, numPredators, _ocean.NumKillerWhales, numObstacles);

            return (numPrey, numPredators, numObstacles);
        }
        #endregion
    }
}
