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
        private SqlCommand cmd;
        private SqlConnection cq;
        private SqlDataReader rd;
        mainWindow mainWindow = new mainWindow();

        registrationForm registrationForm = new registrationForm();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cq = Connection.getConn();
            cq.Open();

            string query = "SELECT Password FROM BakerTrack_Accounts WHERE UserName = @UserName ";

            try
            {
                cmd = new SqlCommand(query, cq);
                cmd.Parameters.AddWithValue("@UserName", username.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                bool accountExist = false;

                while (reader.Read())
                {
                    accountExist = true;
                    if (reader[0].ToString().Equals(password.Text)) {
                        mainWindow.Show();
                        this.Hide();
                        break;
                    } else {
                        MessageBox.Show("Password doesn't match. Try again.");
                        break;
                    }
                }
                if (!accountExist)
                {
                    MessageBox.Show("Account name does not exist, please try again.");
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
            registrationForm.Show();
            this.Hide();
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
