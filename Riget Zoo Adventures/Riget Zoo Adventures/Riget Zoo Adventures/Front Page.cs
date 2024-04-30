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
    public partial class frmFrontPage : Form
    {
        public frmFrontPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Creates the register form
            frmRegister Register = new frmRegister();

            //Shows the register form
            Register.Show();

            //Hides the current form
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Creates the login form
            frmLogin login = new frmLogin();

            //Shows the login form
            login.Show();

            //Hides the current form
            this.Hide();
        }
    }
}
