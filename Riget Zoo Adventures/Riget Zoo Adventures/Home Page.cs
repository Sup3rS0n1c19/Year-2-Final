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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnHotelInformation_Click(object sender, EventArgs e)
        {
            //Creates the hotel information form
            frmHotelInformation hotelInformation = new frmHotelInformation();

            //Shows the hotel information form
            hotelInformation.Show();

            //Hides the current form
            this.Hide();
        }

        private void btnZooInformation_Click(object sender, EventArgs e)
        {
            //Creates the zoo information form
            frmZooInformation zooInformation = new frmZooInformation();

            //Shows the zoo information form
            zooInformation.Show();

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
    }
}
