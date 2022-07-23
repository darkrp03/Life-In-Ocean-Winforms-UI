using OceanLogic;
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
        private readonly Bitmap _killerWhaleImage;
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

            _preyImage = new Bitmap(GameSettings.PreyImagePath);
            _predatorImage = new Bitmap(GameSettings.PredatorImagePath);
            _killerWhaleImage = new Bitmap(GameSettings.KillerWhaleImagePath);
            _obstacleImage = new Bitmap(GameSettings.ObstacleImagePath);

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

        public EventHandler ButtonContinue_Click
        {
            set => buttonContinue.Click += value;
        }

        public EventHandler ButtonStop_Click
        {
            set => buttonStop.Click += value;
        }

        public EventHandler ButtonSpeakerOn_Click
        {
            set => buttonSpeakerOn.Click += value;
        }

        public EventHandler ButtonSpeakerOff_Click
        {
            set => buttonSpeakerOff.Click += value;
        }

        public Button ButtonBack
        {
            get => buttonBack;
        }

        public Button ButtonResetGame
        {
            get => buttonResetGame;
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
        /// Enables "Stop" button.
        /// </summary>
        public void EnableButtonStop()
        {
            buttonContinue.Enabled = false;
            buttonContinue.Hide();

            buttonStop.Enabled = true;
            buttonStop.Show();
        }

        /// <summary>
        /// Disables "Stop" button.
        /// </summary>
        public void DisableButtonStop()
        {
            buttonContinue.Show();
            buttonContinue.Enabled = true;

            buttonStop.Enabled = false;
            buttonStop.Hide();
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
                        if (cell is Prey)
                        {
                            gameField.Rows[i].Cells[j].Value = _preyImage;
                        }
                        if (cell is Predator)
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
        public (int, int, int, int) DisplayAndGetStats(int iteration) //Displays and returns stats
        {
            int numPrey = 0, numPredators = 0, numKillerWhales = 0, numObstacles = 0;

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
                    if (gameField.Rows[i].Cells[j].Value == _killerWhaleImage)
                    {
                        numKillerWhales++;
                    }
                }
            }
            labelInfo.Text = $"Iterations: {iteration}  Prey: {numPrey}  Predators: {numPredators}  Killer Whales: {numKillerWhales}  Obstacles: {numObstacles}     ";

            return (numPrey, numPredators, numKillerWhales, numObstacles);
        }
        #endregion
    }
}
