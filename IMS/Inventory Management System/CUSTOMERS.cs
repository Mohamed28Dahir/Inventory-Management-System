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
    public partial class CUSTOMERS : Form
    {
        SqlCommand cmd;
        SqlDataReader read;
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");

        public CUSTOMERS()
        {
            InitializeComponent();
        }

        private void CUSTOMERS_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customers", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataviewCus.DataSource = dt;
            }
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
            RCustomers rCustomers = new RCustomers();   
            rCustomers.Show();
        }
        public void display()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");
                con.Open();
                DataSet set = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers", con);
                adapter.Fill(set, "Customers");
                dataviewCus.DataSource = set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtseach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtserch.Text == "")
                {
                    display();
                }
                else
                {
                    string query = "select * from Customers where Customers_Id = '" + txtserch.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataSet set = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(set, "Customers");
                    dataviewCus.DataSource = set.Tables[0];
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string query = "delete from Customers where Customers_Id= '" + txtserch.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show(result == 1 ? "Delete is Done" : "Failed");
            display();
            txtserch.Clear();
            con.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            RCustomers RCUS = new RCustomers();
            RCUS.Show();

            string query = "Select * from Customers where Customers_Id = '" + txtserch.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                RCUS.txt_ID.Text = read.GetValue(0).ToString();
                RCUS.txtCname.Text = read.GetValue(1).ToString();
                RCUS.txtNumber.Text = read.GetValue(2).ToString();
                RCUS.txtEmail.Text = read.GetValue(3).ToString();

                con.Close();

            }
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
