using System.Drawing;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class HelperForm : Form
    {
        public HelperForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            panelHelper.BackColor = Color.FromArgb(120, Color.Black);
        }
    }
}
