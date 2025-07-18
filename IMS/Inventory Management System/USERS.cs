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

    public partial class USERS : Form
    {
        SqlCommand cmd;
        SqlDataReader read;
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");
        public USERS()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard BDash = new Dashboard();
            BDash.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RUsers rUsers = new RUsers();
            rUsers.Show();
        }
        public void display()
        {
            try
            {
                con.Open();
                DataSet set = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Products", con);
                adapter.Fill(set, "Products");
                dataview.DataSource = set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            RUsers USER = new RUsers();
            USER.Show();

            string query = "Select * from Login where ID = '" + txtserch.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                USER.txt_ID.Text = read.GetValue(0).ToString();
                USER.txtUserName.Text = read.GetValue(1).ToString();
                USER.txtPassword.Text = read.GetValue(2).ToString();
                

                con.Close();

            }
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtserch.Text == "")
                {
                    display();
                }
                else
                {
                    string query = "select * from Login where ID = '" + txtserch.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataSet set = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(set, "Login");
                    dataview.DataSource = set.Tables[0];
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void USERS_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Login", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataview.DataSource = dt;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string query = "delete from Login where ID= '" + txtserch.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show(result == 1 ? "Delete is Done" : "Failed");
            display();
            txtserch.Clear();
            con.Close();
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
