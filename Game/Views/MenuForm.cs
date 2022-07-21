using System.Windows.Forms;

namespace Game.Views
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        public Button PlayButton
        {
            get => playButton;
        }

        public Button SettingsButton
        {
            get => settingsButton;
        }

        public Button ExitButton
        {
            get => exitButton;
        }
    }
}
