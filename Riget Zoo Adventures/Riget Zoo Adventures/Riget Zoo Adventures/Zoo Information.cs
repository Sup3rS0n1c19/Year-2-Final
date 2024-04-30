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
    public partial class frmZooInformation : Form
    {
        public frmZooInformation()
        {
            InitializeComponent();
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

        private void btnAnimalInformation_Click(object sender, EventArgs e)
        {
            //Creates the animal information form
            frmAnimalInformation animalInformation = new frmAnimalInformation();

            //Shows the animal information form
            animalInformation.Show();

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

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            //Creates the hotel booking form
            frmTicketBooking ticketBooking = new frmTicketBooking();

            //Shows the hotel booking form
            ticketBooking.Show();

            //Hides the current form
            this.Hide();
        }
    }
}
