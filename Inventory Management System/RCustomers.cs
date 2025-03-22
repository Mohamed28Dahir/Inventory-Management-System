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
    public partial class RCustomers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
        SqlCommand cmd;
        public RCustomers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ID.Text == "" || txtCname.Text == "" || txtNumber.Text == "" || txtEmail.Text == "" )
                {
                    MessageBox.Show("Please fill Customer Info ");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customers values ( '" + txt_ID.Text + "' , '" + txtCname.Text + "', '" + txtNumber.Text + "', '" + txtEmail.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer succeful Registred ");
                    txtCname.Text = "";
                    txtNumber.Text = "";
                    txtEmail.Text = "";
                    con.Close();
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PRODUCTS form = new PRODUCTS();
            //    String query = "Update Customers set Customers_Name = '" + txtCname.Text + "' , Customers_Numbers= '" + txtNumber.Text + "', Customers_Email= '" + txtEmail.Text + "'  where Customers_Id = '" + txt_ID.Text + "'";
            //    con.Open();
            //    cmd = new SqlCommand(query, con);
            //    int result = cmd.ExecuteNonQuery();
            //    MessageBox.Show(result == 1 ? "Update is Done" : "Failed");
            //    Display();
            //    con.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void Display()
        {
            try
            {
                PRODUCTS form = new PRODUCTS();
                SqlConnection con = new SqlConnection("Server=MOHA16\\SQLEXPRESS; Initial Catalog=IMS ;Integrated Security=True");
                con.Open();
                DataSet set = new DataSet();
                string query = "select * from Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(set, "Products");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RCustomers_Load(object sender, EventArgs e)
        {
            Display();
            txt_ID.Text= generatuserId();

        }
        public String generatuserId()
        {

            int curentId = 0;
            string genertedID = "CUS_100";
            con.Open();
            cmd = new SqlCommand("select Count(Products_Id) from Products ", con);
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.Read())
            {
                curentId = Convert.ToInt32(dr[0]) + 1;
                txt_ID.Text = genertedID + curentId;
            }

            else
            {
                txt_ID.Text = genertedID + curentId;
            }

            con.Close();

            return txt_ID.Text;

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTOMERS RCUS = new CUSTOMERS();
            RCUS.Show();
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
