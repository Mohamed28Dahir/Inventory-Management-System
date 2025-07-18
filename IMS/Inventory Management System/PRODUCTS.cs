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
    public partial class PRODUCTS : Form
    {
        SqlCommand cmd; 
        SqlDataReader read;
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");

        public PRODUCTS()
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
            RProducts rPro= new RProducts();
            rPro.Show();
        }

        public void display()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PRODUCTS_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataview.DataSource = dt;
            }
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RProducts RPro = new RProducts();
            RPro.Show();

            string query = "Select * from Products where Products_Id = '" + txtserch.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                RPro.txt_ID.Text= read.GetValue(0).ToString();
                RPro.txtPname.Text = read.GetValue(1).ToString();
                RPro.txtPrice.Text = read.GetValue(2).ToString();
                RPro.txtDesc.Text = read.GetValue(3).ToString();

                con.Close();

            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtserch.Text == "")
                {
                    display();
                }
                else
                {
                    string query = "select * from Products where Products_Id = '" + txtserch.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataSet set = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(set, "Products");
                    dataview.DataSource = set.Tables[0];
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "delete from Products where Products_Id= '" + txtserch.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show(result == 1 ? "Delete is Done" : "Failed");
            display();
            txtserch.Clear();
            con.Close();
        }
    }
}
