using OceanLogic;
using OceanLogic.GameObjects;
using OceanLogic.Interfaces;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class GameForm : Form
    {
        #region Fields
        private readonly IOceanViewer _ocean;
        private readonly Bitmap _preyImage;
        private readonly Bitmap _predatorImage;
        private readonly Bitmap _obstacleImage;
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

            _preyImage = new Bitmap(GameSettings.defaultPreyImagePath);
            _predatorImage = new Bitmap(GameSettings.defaultPredatorImagePath);
            _obstacleImage = new Bitmap(GameSettings.defaultObstaclerImagePath);

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
            get => timer1;
        }

        public Button ContinueButton
        {
            get => continueButton;
        }

        public Button StopButton
        {
            get => stopButton;
        }

        public Button BackButton
        {
            get => backButton;
        }

        public Button ResetGameButton
        {
            get => resetGameButton;
        }
        #endregion

        #region Methods      
        private new void DoubleBuffered(bool enabled) //Enable double buffered for DatagridView
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            gameField, new object[] { enabled });
        }

        public void DisplayInitialText() //Display initial text when form loaded
        {
            labelInfo.Text = $"Iterations: 0  Prey: {_ocean.NumPrey}  Predators: {_ocean.NumPredators}  Obstacles: {_ocean.NumObstacles}    ";
        }

        public void DisplayCells() //Displays cells in table
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
                    }
                    else
                    {
                        gameField.Rows[i].Cells[j].Value = null;
                    }
                }
            }

            gameField.Refresh();
        }

        public (int, int, int) DisplayAndGetStats(int iteration) //Displays and returns stats
        {
            int numPrey = 0, numPredators = 0, numObstacle = 0;

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
                        numObstacle++;
                    }
                }
            }

            labelInfo.Text = $"Iterations: {iteration}  Prey: {numPrey}  Predators: {numPredators}  Obstacles: {numObstacle}     ";         

            return (numPrey, numPredators, numObstacle);
        }
        #endregion
    }
}
