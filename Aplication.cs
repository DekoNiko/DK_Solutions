using DKsolutions.View;

namespace DKsolutions
{
    public partial class Aplication : Form
    {
        public Aplication()
        {
            InitializeComponent();
            DefaultConfigs();
            UserSignOption();
        }

        #region DefaultProgram
        public void DefaultConfigs()
        {
            var menuBar = menuStrip1;
            menuStrip1.Hide();
            menuBar.Height = 2;

            var panelWind = panel1;


            panel1.Controls.Clear();
        }
        #endregion

        public void UserSignOption()
        {
            var signUser = new SignUserView();
            panel1.Controls.Add(signUser);
            signUser.Location = new Point(panel1.Width / 3, panel1.Height / 4);
        }


    }
}
