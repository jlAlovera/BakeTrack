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
using System.Data.Sql;

namespace OOP_BakeTrack_Final
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cq;
        SqlDataReader rd;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cq = Connection.getConn();
            cq.Open();

            string query = "SELECT COUNT(*) FROM BakeTrack_Accounts WHERE UserName = @UserName";

            try
            {
                cmd = new SqlCommand(query, cq);
                cmd.Parameters.AddWithValue("@UserName", username.Text);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    new mainWindow().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account name does not exists, please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cq.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '●';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new registrationForm().Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
