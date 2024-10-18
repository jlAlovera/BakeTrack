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

namespace OOP_BakeTrack_Final
{
    public partial class registrationForm : Form
    {
        SqlCommand cmd;
        SqlConnection cq;
        SqlDataReader rd;

        public registrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("All textfields must be filled. Please input the information required and try again.", "Registration Failled.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text && txtUsername.Text != "")
            {
                cq = Connection.getConn();
                cq.Open();

                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string conPass = txtConPassword.Text;

                cmd = new SqlCommand("INSERT INTO BakerTrack_Accounts (UserName, Password) values (@UserName,@Password)", cq);

                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();

                txtUsername.Clear();
                txtPassword.Clear();
                txtConPassword.Clear();

                MessageBox.Show("Account Registration Sucessful.");
            }
            else
            {
                MessageBox.Show("Registration Failed. Please check your input.", "Registration Failled.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConPassword.Clear();
            txtUsername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtConPassword.PasswordChar = '●';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }
    }


}
