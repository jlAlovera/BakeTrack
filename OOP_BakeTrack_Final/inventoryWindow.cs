using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Data.SqlClient;


namespace OOP_BakeTrack_Final
{
    public partial class inventoryWindow : Form
    {
        public inventoryWindow()
        {
            InitializeComponent();
            refreshTable();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryWindow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        bool sidebarExpand = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    sidebar.Width = sidebar.MinimumSize.Width;
                }
            }
            else
            {
                sidebar.Width += 20;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    sidebar.Width = sidebar.MaximumSize.Width;
                }
            }
        }

        private void refreshTable()
        {
            dataGridView.Rows.Clear();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredients", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                dataGridView.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString(),
                    reader[4].ToString(),
                    ((DateTime) reader[5]).ToShortDateString(),
                    ((DateTime) reader[6]).ToShortDateString(),
                    reader[7].ToString());
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        private void clearFields()
        {
            textBoxName.Text = "";
            textBoxQuantity.Text = "";
            textBoxMeasureUnit.Text = "";
            textBoxCost.Text = "";
            textBoxReorder.Text = "";
            dtpExpiration.Value = DateTime.Now;
            dtpPurchase.Value = DateTime.Now;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int quantity;
            try {
                quantity = Convert.ToInt32((string)textBoxQuantity.Text);
            }
            catch (Exception ex) { MessageBox.Show("Invalid quantity."); return; }
            string measure_unit = textBoxMeasureUnit.Text;
            double cost;
            try
            {
                cost = Convert.ToDouble((string)textBoxCost.Text);
            }
            catch (Exception ex) { MessageBox.Show("Invalid cost."); return; }
            int reorder_lvl;
            try
            {
                reorder_lvl = Convert.ToInt32((string)textBoxReorder.Text);
            }
            catch (Exception ex) { MessageBox.Show("Invalid re-order level."); return; }

            string expirationDate = dtpExpiration.Value.ToShortDateString();
            string purchaseDate = dtpPurchase.Value.ToShortDateString();

            int id = Connection.getVacantID("Ingredients");

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ingredients(id, name, quantity, measurement_unit, reorder_level, purchase, expiration, cost_per_unit) VALUES (" +
                                            id + ", '" + name + "', " + quantity + ", '" + measure_unit + "', '" + reorder_lvl + "', CAST('" + purchaseDate + "' AS Date), CAST('" + expirationDate + "' AS Date), CAST('" + cost + "' AS FLOAT))", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            refreshTable();
            clearFields();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
