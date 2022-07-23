using System;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class MenuForm : Form
    {
        #region Ctor      
        public MenuForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
        #endregion

        #region Properties
        public EventHandler ButtonPlay_Click
        {
            set => playButton.Click += value;
        }   

        public EventHandler ButtonSettings_Click
        {
            set => settingsButton.Click += value;
        }

        public EventHandler ButtonExit_Click
        {
            set => exitButton.Click += value;
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
        #endregion
    }
}
