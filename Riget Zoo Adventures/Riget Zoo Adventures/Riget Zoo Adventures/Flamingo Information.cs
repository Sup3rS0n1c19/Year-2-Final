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
    public partial class frmFlamingoInformation : Form
    {
        public frmFlamingoInformation()
        {
            InitializeComponent();
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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //Creates the animal information form
            frmAnimalInformation animalInformation = new frmAnimalInformation();

            //Shows the animal information form
            animalInformation.Show();

            //Hides the current form
            this.Hide();
        }
    }
}
