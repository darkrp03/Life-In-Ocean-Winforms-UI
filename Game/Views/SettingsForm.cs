using OceanLogic.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class SettingsForm : Form
    {
        #region Fields      
        private readonly IOceanViewer _ocean; //Object for getting information from business logic
        #endregion

        #region Ctor       
        public SettingsForm(IOceanViewer ocean)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            panel1.BackColor = Color.FromArgb(100, Color.Black);

            _ocean = ocean;

            SetDefaultTextBoxValue();
        }
        #endregion

        #region Properties      
        public Label LabelWarning
        {
            get => labelWarning;
        }
        
        public EventHandler ButtonApply_Click
        {
            set => buttonApply.Click += value;
        }

        public EventHandler ButtonCancel_Click
        {
            set => buttonCancel.Click += value;
        }

        public string AmoutOfPrey
        {
            get => textBoxPrey.Text;
        }

        public string AmoutOfPredators
        {
            get => textBoxPredators.Text;
        }

        public string AmountOfKillerWhales
        {
            get => textBoxKillerWhales.Text;
        }

        public string AmoutOfObstacles
        {
            get => textBoxObstacles.Text;
        }
        
        public string AmoutOfIterations
        {
            get => iterationsTextBox.Text;
        }
        #endregion

        #region Methods
        public void SetDefaultTextBoxValue()
        {
            textBoxPrey.Text = _ocean.NumPrey.ToString();
            textBoxObstacles.Text = _ocean.NumObstacles.ToString();
            textBoxPredators.Text = _ocean.NumPredators.ToString();
            textBoxKillerWhales.Text = _ocean.NumKillerWhales.ToString();
            iterationsTextBox.Text = _ocean.NumIterations.ToString();
        }
        #endregion
    }
}
