using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riget_Zoo_Adventures
{
    public partial class frmAnimalInformation : Form
    {
        public frmAnimalInformation()
        {
            InitializeComponent();
        }

        private void picLion_Click(object sender, EventArgs e)
        {
            //Creates the lion information form
            frmLionInformation lionInformation = new frmLionInformation();

            //Shows the lion information form
            lionInformation.Show();

            //Hides the current form
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Creates the front page form
            frmFrontPage frontPage = new frmFrontPage();

            //Displays the front page form
            frontPage.Show();

            //Hides the current form
            this.Hide();
        }

        private void picPanda_Click(object sender, EventArgs e)
        {
            //Creates the panda information form
            frmPandaInformation pandaInformation = new frmPandaInformation();

            //Shows the panda information form
            pandaInformation.Show();

            //Hides the current form
            this.Hide();
        }

        private void picFlamingo_Click(object sender, EventArgs e)
        {
            //Creates the flamingo information form
            frmFlamingoInformation flamingoInformation = new frmFlamingoInformation();

            //Shows the flamingo information form
            flamingoInformation.Show();

            //Hides the current form
            this.Hide();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //Creates the home page form
            frmHomePage homePage = new frmHomePage();

            //Shows the home page form
            homePage.Show();

            //Hides the current form
            this.Hide();
        }

        private void picEmu_Click(object sender, EventArgs e)
        {
            //Creates the emu information form
            frmEmuInformation emuInformation = new frmEmuInformation();

            //Shows the emu information form
            emuInformation.Show();

            //Hides the current form
            this.Hide();
        }

        private void picMacaw_Click(object sender, EventArgs e)
        {
            //Creates the macaw information form
            frmMacawInformation macawInformation = new frmMacawInformation();

            //Shows the macaw information form
            macawInformation.Show();

            //Hides the current form
            this.Hide();
        }

        private void picElephant_Click(object sender, EventArgs e)
        {
            //Creates the elephant information form
            frmElephantInformation elephantInformation = new frmElephantInformation();

            //Shows the elephant information form
            elephantInformation.Show();

            //Hides the current form
            this.Hide();
        }
    }
}
