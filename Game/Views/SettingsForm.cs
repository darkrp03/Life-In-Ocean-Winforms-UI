using OceanLogic.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class SettingsForm : Form
    {
        #region Fields      
        private readonly IOceanViewer _ocean;
        #endregion

        #region Ctor       
        public SettingsForm(IOceanViewer ocean)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            panel1.BackColor = Color.FromArgb(100, Color.Black);

            _ocean = ocean;

            preyTextBox.Text = _ocean.NumPrey.ToString();
            obstaclesTextBox.Text = _ocean.NumObstacles.ToString();
            predatorsTextBox.Text = _ocean.NumPredators.ToString();
            iterationsTextBox.Text = _ocean.NumIterations.ToString();
        }
        #endregion

        #region Properties      
        public Label WarningLabel
        {
            get => warningLabel;
        }
        
        public Button ApplyButton
        {
            get => applyButton;
        }

        public new Button CancelButton
        {
            get => cancelButton;
        }

        public string AmoutOfPrey
        {
            get => preyTextBox.Text;
        }

        public string AmoutOfPredators
        {
            get => predatorsTextBox.Text;
        }

        public string AmoutOfObstacles
        {
            get => obstaclesTextBox.Text;
        }

        public string AmoutOfIterations
        {
            get => iterationsTextBox.Text;
        }
        #endregion
    }
}
