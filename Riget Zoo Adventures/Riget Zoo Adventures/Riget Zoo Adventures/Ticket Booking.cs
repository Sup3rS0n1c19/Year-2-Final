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

namespace Riget_Zoo_Adventures
{
    public partial class frmTicketBooking : Form
    {
        public frmTicketBooking()
        {
            InitializeComponent();
        }

        private void btbMakeBooking_Click(object sender, EventArgs e)
        {
            //Attributes
            string username;
            string password;
            bool booked;
            int ticketId;

            string creditCardNumber = txtCardNumber.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            string startDate = calStartDate.SelectionRange.Start.ToShortDateString();
            string endDate = calEndDate.SelectionRange.Start.ToShortDateString();
            booked = true;
            ticketId = 0;

            //Tells the code where the database is
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\EXAM1240\\OneDrive - Middlesbrough College\\Documents\\Declan Carroll\\Task 2\\Riget Zoo Adventures\\Riget Zoo Adventures\\Customer.mdf; Integrated Security = True; Connect Timeout = 30";



            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Use stored procedure

            SqlCommand command = new SqlCommand("CreateNewTicket", sqlConnection);

            List<Ticket> ticketList = new List<Ticket>();
            SqlCommand cdm = new SqlCommand("GetTicketDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cdm);
            DataTable td = new DataTable();

            sqlConnection.Open();
            ds.Fill(td);
            sqlConnection.Close();

            foreach (DataRow dr in td.Rows)
            {
                ticketList.Add(
                    new Ticket()
                    {
                        TicketId = Convert.ToInt32(dr["TicketId"]),
                        Username = Convert.ToString(dr["Username"]),
                        Password = Convert.ToString(dr["Password"]),
                        StartDate = Convert.ToString(dr["StartDate"]),
                        EndDate = Convert.ToString(dr["EndDate"]),
                        CreditCardNumber = Convert.ToString(dr["CreditCardNumber"])
                    });
            }
            foreach (Ticket ticket in ticketList)
            {
                if (startDate == ticket.StartDate)
                {
                    booked = false;
                    break;
                }
                else
                {
                    booked = true;
                }

                if (endDate == ticket.EndDate)
                {
                    booked = false;
                    break;
                }
                else
                {
                    booked = true;
                }
                if (creditCardNumber == ticket.CreditCardNumber)
                {
                    booked = false;
                    break;
                }
                else
                {
                    booked = true;
                }

                if (creditCardNumber.Length != 16)
                {
                    booked = false;
                    break;
                }
                else
                {
                    booked = true;
                }
            }
            if (booked == false)
            {
                MessageBox.Show("This booking cannot be made");
            }
            if (booked == true)
            {
                MessageBox.Show("Your booking was successful");

                //Call stored procedure passing name and age as parameters

                command.Parameters.AddWithValue("@ticketId", ticketId);

                command.Parameters.AddWithValue("@Username", username);

                command.Parameters.AddWithValue("@Password", password);

                command.Parameters.AddWithValue("@StartDate", startDate);

                command.Parameters.AddWithValue("@EndDate", endDate);

                command.Parameters.AddWithValue("@CreditCardNumber", creditCardNumber);


                //Open connection to database, execute stored procedure and close the connection

                sqlConnection.Open();

                command.ExecuteNonQuery();

                sqlConnection.Close();
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
