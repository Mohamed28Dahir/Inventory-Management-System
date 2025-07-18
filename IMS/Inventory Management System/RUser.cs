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
    public partial class RUsers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MOHA16\\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
        SqlCommand cmd;
        public RUsers()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {

            this.Hide();    
            USERS UN = new USERS();
            UN.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ID.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" )
                {
                    MessageBox.Show("Please fill User ");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Login values ( '" + txtUserName.Text + "' , '" + txtPassword.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User succeful Registred ");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                   
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
                String query = "Update Login set Username = '" + txtUserName.Text + "' , Password= '" + txtPassword.Text +  "' where Products_id = '" + txt_ID.Text + "'";
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
                string query = "select * from Login";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(set, "Login");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RUsers_Load(object sender, EventArgs e)
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

                genertedID = "USER_100" + (curentId + 1);
            }

            else
            {
                genertedID = "USER_100";
            }

            con.Close();

            return genertedID;

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                PRODUCTS form = new PRODUCTS();
                String query = "Update Login set Username = '" + txtUserName.Text + "' , Password= '" + txtPassword.Text + "' where ID = '" + txt_ID.Text + "'";
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
    }
}
