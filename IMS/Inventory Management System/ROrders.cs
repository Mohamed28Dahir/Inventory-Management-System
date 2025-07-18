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

namespace Inventory_Management_System
{
    public partial class ROrders : Form
    {
        SqlCommand cmd;
        SqlDataReader read;
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;");

        public ROrders()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ORDERS BO = new ORDERS();
            BO.Show();

        }

        private void ROrders_Load(object sender, EventArgs e)
        {
            generatuserId();

            using (SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataview.DataSource = dt;

            }
            using (SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customers", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCus.DataSource = dt;
            }
        }
        public String generatuserId()
        {

            int curentId = 0;
            string genertedID = "Orders_100";
            con.Open();
            cmd = new SqlCommand("select Count(Products_Id) from Products ", con);
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.Read())
            {
                curentId = Convert.ToInt32(dr[0])+ 1;

                txt_ID.Text = genertedID +  curentId;
            }

            else
            {
                txt_ID.Text = genertedID + curentId;
            }

            con.Close();

            return txt_ID.Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
                dataGridViewCus.DataSource = set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSearchPRO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchCUS.Text == "")
                {
                    display();
                }
                else
                {
                    string query = "select * from Customers where Customers_Id = '" + txtSearchCUS.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataSet set = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(set, "Customers");
                    dataGridViewCus.DataSource = set.Tables[0];
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the form
                //int Orders_Id = int.Parse(txt_ID.Text);
                //int Customers_Id = int.Parse(txtCusID.Text);
                string Customers_Id = txtCusID.Text;
                //int Products_Id = int.Parse(txtProID.Text);
                string Products_Name = txtProName.Text;
                DateTime Orders_Date = dateTimePicker.Value;
                decimal Price = decimal.Parse(txtprice.Text);
                int Qty = int.Parse(txtQty.Text);
                decimal TotalAmount = Price * Qty;
                string Orders_Id = txt_ID.Text;
                string Customers_Name = txtCusN.Text;
                string Products_Id = txtProID.Text;

                // Insert data into database
                using (SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True;"))

                {
                    con.Open();
                    string query = "INSERT INTO Orders   (Orders_Id,Customers_Id, Customers_Name, Products_Id, Products_Name, Orders_Date, Price, Qty, TotalAmount) " +
                                   "VALUES (@Orders_Id,@Customers_Id, @Customers_Name, @Products_Id, @Products_Name, @Orders_Date, @Price, @Qty, @TotalAmount)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Orders_Id", Orders_Id);
                        cmd.Parameters.AddWithValue("@Customers_Id", Customers_Id);
                        cmd.Parameters.AddWithValue("@Customers_Name", Customers_Name);
                        cmd.Parameters.AddWithValue("@Products_Id", Products_Id);
                        cmd.Parameters.AddWithValue("@Products_Name", Products_Name);
                        cmd.Parameters.AddWithValue("@Orders_Date", Orders_Date);
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@Qty", Qty);
                        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order is successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchCUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ORDERS form = new ORDERS();
                string query = "Update Orders set Orders_Id='" + txt_ID.Text + "',Products_Id='" + txtProID + "',Products_Name='" + txtProName.Text + "',Customers_Id='" + txtCusID.Text + "',Customers_Name='" + txtCusID.Text + "',Qty='" + txtQty.Text + "' ,Price='" + txtprice.Text + "',TotalAmount='" + textBox3 + "'where Orders_Id='" + txt_ID.Text + "'";
                con.Open();
                cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                MessageBox.Show(result == 1 ? "Update is Done" : "Failed");
                con.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }
    }
}