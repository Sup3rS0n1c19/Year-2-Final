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
using System.Xml.Linq;

namespace Riget_Zoo_Adventures
{
    public partial class frmRegister : Form
    {
        public frmRegister()
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

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            //Attributes
            string username;
            string password;
            bool registration;

            registration = true;

            //Input Username
            username = txtUsername.Text;

            //Input Password
            password = txtPassword.Text;

            //Checks if the username is 50 characters long
            if (username.Length > 50)
            {
                //Tells the user their username is too long
                MessageBox.Show("This username is too long, please choose another");
            }
            else
            {
                //Checks if the password is 50 characters long
                if (password.Length > 50)
                {
                    //Tells the user their password is too long
                    MessageBox.Show("This password is too long, please choose another");
                }
                else
                {
                    //Tells the code where the database is
                    string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\EXAM1240\\OneDrive - Middlesbrough College\\Documents\\Declan Carroll\\Task 2\\Riget Zoo Adventures\\Riget Zoo Adventures\\Customer.mdf; Integrated Security = True; Connect Timeout = 30";

                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    //Use stored procedure

                    SqlCommand command = new SqlCommand("CreateNewCustomerRecord", sqlConnection);

                    List<Customer> customerList = new List<Customer>();

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
                            new Customer()
                            {
                                Username = Convert.ToString(dr["Username"]),
                                Password = Convert.ToString(dr["Password"])
                            });
                    }
                    foreach (Customer customer in customerList)
                    {
                        //Checks if the username has already been taken
                        if (customer.Username == txtUsername.Text)
                        {
                            registration = false;
                            break;
                        }
                        else
                        {
                            registration = true;
                        }
                    }
                    if (registration == true)
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Input details from form

                        string Username = txtUsername.Text;

                        string Password = txtPassword.Text;

                        int Id = 0;


                        //Call stored procedure passing name and age as parameters

                        command.Parameters.AddWithValue("@Username", Username);

                        command.Parameters.AddWithValue("@Password", Password);

                        command.Parameters.AddWithValue("Id", Id);


                        //Open connection to database, execute stored procedure and close the connection

                        sqlConnection.Open();

                        command.ExecuteNonQuery();

                        sqlConnection.Close();

                        //Tells the user their account was created successfully
                        MessageBox.Show("Account created successfully");

                        //Creates the login form
                        frmLogin login = new frmLogin();

                        //Shows the login form
                        login.Show();

                        //Hides the current form
                        this.Hide();
                    }
                    if (registration == false)
                    {
                        //Tells the user their password has been taken
                        MessageBox.Show("This username has already been taken, please try again.");
                    }
                }
            }
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

        private void picHidePassword_Click(object sender, EventArgs e)
        {
            //Makes the password invisible by adding the system password characters
            txtPassword.UseSystemPasswordChar = true;

            //Makes the hide password button invisible
            picHidePassword.Visible = false;

            //Makes the show password button visible
            picShowPassword.Visible = true;
        }
    }
}