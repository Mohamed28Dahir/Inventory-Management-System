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


namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            // Xogta user-ka
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            // Xiro SQL Server
            SqlConnection con = new SqlConnection("server=MOHA16\\SQLEXPRESS; database=IMS;Integrated Security=true");

            con.Open();
            // Query-ga xaqiijinaya user
            string query = "SELECT * FROM Login WHERE Username = '"+username+ "' AND Password = '"+password+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            


            // Ku dar Parameters
            //cmd.Parameters.AddWithValue("@username", username);
            //cmd.Parameters.AddWithValue("@password", password);

            if (dr.Read())
            {
                //MessageBox.Show("Login Successful!");
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }

            con.Close(); // Xir xiriirka database
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = ""; // Clear Username
            txtPassword.Text = ""; // Clear Password
            txtUserName.Focus();   // Set focus back to Username
        }


        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }
    }
}
