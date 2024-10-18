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
    public partial class shoppingListWindow : Form
    {
        private Form parentWindow;
        public shoppingListWindow(Form pa)
        {
            InitializeComponent();
            updateLackingIngredients();

            parentWindow = pa;
        }

        private void updateLackingIngredients()
        {
            dataGridView.Rows.Clear();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id, name, purchase_date, quantity, cost_per_unit, reorder_level FROM BakeTrack_Inventory ORDER BY id", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int current_level = Convert.ToInt32(reader[3]);
                int reorder_level = Convert.ToInt32(reader[5]);
                if (current_level >= reorder_level)
                {
                    continue;
                }
                double cost_per_unit = Convert.ToDouble(reader[4]);
                double needed = (reorder_level - current_level) * cost_per_unit;
                dataGridView.Rows.Add(
                    false,
                    reader[0].ToString(),
                    reader[1].ToString(),
                    ((DateTime)reader[2]).ToShortDateString(),
                    reader[3].ToString(),
                    String.Format("{0:0.00}", needed)
                );
            }

            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {

        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            Hide();
            parentWindow.Show();
        }
    }
}
