using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Riget_Zoo_Adventures
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        private void btnLogIntoAccount_Click(object sender, EventArgs e)
        {
            {
                //Attributes
                string username;
                string password;
                bool login;

                username = txtUsername.Text;
                password = txtPassword.Text;
                login = false;

                //Read a person record

                List<Customer> customerList = new List<Customer>();

                //Tells the code where the database is
                string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\EXAM1240\\OneDrive - Middlesbrough College\\Documents\\Declan Carroll\\Task 2\\Riget Zoo Adventures\\Riget Zoo Adventures\\Customer.mdf; Integrated Security = True; Connect Timeout = 30";



                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("GetCustomerDetails", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sqlConnection.Open();
                sd.Fill(dt);
                sqlConnection.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    customerList.Add(
                        new Customer
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Username"]),
                            Password = Convert.ToString(dr["Password"])
                        });
                }
                foreach (Customer customer in customerList)
                {
                    //Checks if the username is correct
                    if (customer.Username == username)
                    {
                        //Checks if the password is correct
                        if (customer.Password == password)
                        {
                            //Tells the user they've successfully logged in
                            MessageBox.Show("You have successfully logged in");

                            //Creates the home page form
                            frmHomePage homePage = new frmHomePage();

                            //Shows the home page form
                            homePage.Show();

                            //Hides the current form
                            this.Hide();

                            login = true;
                            break;
                        }
                        else
                        {
                            login = false;
                        }
                    }
                    else
                    {
                        login = false;
                    }
                }
                //Checks if login is false
                if (login == false) 
                {
                    //Tells the user that their details were incorrect
                    MessageBox.Show("Your details were not correct, please try again");
                }
            }
        }

        private void picHidePassword_Click(object sender, EventArgs e)
        {
            //Makes the password invisible by adding the system password characters
            txtPassword.UseSystemPasswordChar = true;

            //Makes the hide password button invisible
            picHidePassword.Visible = false;

            //Makes the show password button visible
            picShowPassword.Visible = true;
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            //Makes the password visible by removing the system password characters
            txtPassword.UseSystemPasswordChar = false;

            //Makes the hide password button visible
            picHidePassword.Visible = true;

            //Makes the show password button invisible
            picShowPassword.Visible = false;
        }
    }
}


