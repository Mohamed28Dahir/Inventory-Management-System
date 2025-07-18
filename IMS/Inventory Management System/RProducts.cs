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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_System
{
    public partial class RProducts : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
        SqlCommand cmd;

        public RProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRODUCTS Pro = new PRODUCTS();
            Pro.Show();
        }

        void fillData()

        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter Da = new SqlDataAdapter("select * from Products  ", con);
                ds.Clear();
                Da.Fill(ds, "Products");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ID.Text == "" || txtPname.Text == "" || txtPrice.Text == "" || txtDesc.Text == "" || comboBoxpro.Text == "")
                {
                    MessageBox.Show("Please fill product ");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Products values ( '"+ txt_ID .Text+ "' , '" + txtPname.Text + "', '" + txtPrice.Text + "', '" + txtDesc.Text + "', '" + comboBoxpro.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product succeful Registred ");
                    txtPname.Text = "";
                    txtPrice.Text = "";
                    txtDesc.Text = "";
                    comboBoxpro.Text = "";
                    con.Close();
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCTS form = new PRODUCTS();
                String query = "Update Products set Products_Name = '" + txtPname.Text + "' , Products_Price= '" + txtPrice.Text + "', Products_Descrip= '" + txtDesc.Text + "' , Products_Category= '"+comboBoxpro.Text+"' where Products_id = '"+txt_ID.Text+"'";
                con.Open();
                cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                MessageBox.Show(result == 1 ? "Update is Done" : "Failed");
                Display();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void RProducts_Load(object sender, EventArgs e)
        {
            txt_ID.Text = generatuserId();
        }

        public String generatuserId()
        {

            int curentId;
            string genertedID;
            con.Open();
            cmd = new SqlCommand("select Count(Products_Id) from Products ", con);
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.Read())
            {
                curentId = Convert.ToInt32(dr[0]);

                genertedID = "PRO_100" + (curentId + 1);
            }

            else
            {
                genertedID = "PRO_100";
            }

            con.Close();

            return genertedID;

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
