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
    public partial class ORDERS : Form
    {

        SqlCommand cmd;
        SqlDataReader read;
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");

        public ORDERS()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard BDash = new Dashboard();
            BDash.Show();
        }

        private void ORDERS_Load(object sender, EventArgs e)
        {
            displayAll();
        }

        public void displayAll()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select*from Orders", con);
                adapter.Fill(dt);
                dataviewOR.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ROrders rOrders = new ROrders();
            rOrders.Show();
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
                dataviewOR.DataSource = set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            try
            {
                if (txnsearchOrder.Text == "")
                {
                    display();
                }
                else
                {
                    string query = "select * from Orders where Orders_Id = '" + txnsearchOrder.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataSet set = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(set, "Orders");
                    dataviewOR.DataSource = set.Tables[0];
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            this.Hide();
            ROrders ro = new ROrders();
            ro.Show();

           

            string query = "Select * from Orders where Orders_Id = '" + txnsearchOrder.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                ro.txt_ID.Text = read.GetValue(0).ToString();
                ro.dateTimePicker.Text = read.GetValue(1).ToString();
                ro.txtProID.Text = read.GetValue(2).ToString();
                ro.txtProName.Text = read.GetValue(3).ToString();
                ro.txtCusID.Text = read.GetValue(4).ToString();
                ro.txtCusN.Text = read.GetValue(5).ToString();
                ro.txtQty.Text = read.GetValue(6).ToString();
                ro.txtprice.Text = read.GetValue(7).ToString();

            }
            con.Close();


        }



        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reboot re = new Reboot();
            re.Show();


            string query = "Select * from Orders where Orders_Id = '" + txnsearchOrder.Text + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                re.dateTimePicker.Text = read.GetValue(1).ToString();
                re.txtProName.Text = read.GetValue(3).ToString();
                re.txtprice.Text = read.GetValue(7).ToString();
                re.txtQty.Text = read.GetValue(6).ToString();
                re.Totaltext.Text = read.GetValue(8).ToString();


            }
            con.Close();
        }
    }
}
