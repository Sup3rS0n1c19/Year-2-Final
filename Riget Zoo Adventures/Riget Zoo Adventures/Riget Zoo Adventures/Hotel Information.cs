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
    public partial class frmHotelInformation : Form
    {
        public frmHotelInformation()
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Creates the front page form
            frmFrontPage frontPage = new frmFrontPage();

            //Displays the front page form
            frontPage.Show();

            //Hides the current form
            this.Hide();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            //Creates the hotel booking form
            frmHotelBooking hotelBooking = new frmHotelBooking();

            //Shows the hotel booking form
            hotelBooking.Show();

            //Hides the current form
            this.Hide();
        }
    }
}
