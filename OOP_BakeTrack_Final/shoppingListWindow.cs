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

namespace OOP_BakeTrack_Final
{
    public partial class shoppingListWindow : Form
    {
        private int selectedId = -1;
        private DataGridViewRow selectedRow = null;
        private double selectedPrice = 0.0;
        private int selectedCurrentAmount = 0;
        private int minRestockAmount = -1;
        private Form parentWindow;
        private inventoryWindow inventoryWindow;
        private bool hasValidRestockAmount = false;
        public shoppingListWindow(Form pa, inventoryWindow inventoryWindow)
        {
            InitializeComponent();
            updateLackingIngredients();

            parentWindow = pa;
            this.inventoryWindow = inventoryWindow;
        }

        public void clearState()
        {
            selectedId = -1;
            selectedRow = null;
            selectedPrice = 0.0;
            selectedCurrentAmount = 0;
            minRestockAmount = -1;
            hasValidRestockAmount = false;
            dataGridView.ClearSelection();

            updateLackingIngredients();
        }

        public void updateLackingIngredients()
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
                int minimum_restock = reorder_level - current_level;
                double cost_per_unit = Convert.ToDouble(reader[4]);
                double needed = (reorder_level - current_level) * cost_per_unit;
                dataGridView.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    ((DateTime)reader[2]).ToShortDateString(),
                    minimum_restock,
                    String.Format("{0:0.00}", cost_per_unit),
                    String.Format("{0:0.00}", needed),
                    reader[3].ToString()
                );
            }

            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        private void clearText()
        {
            textBoxAmount.Text = "";
            hasValidRestockAmount = false;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            selectedId = -1;
            selectedRow = null;
            selectedPrice = 0.0;
            clearText();
            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (dataGridView.SelectedRows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    DataGridViewRow row = dataGridView.SelectedRows[i];
                    selectedId = Convert.ToInt32(row.Cells[0].Value);
                    labelName.Text = "Name: " + row.Cells[1].Value.ToString();
                    labelLastRestock.Text = "Last Restock: " + row.Cells[2].Value.ToString();
                    textBoxAmount.Text = row.Cells[3].Value.ToString();
                    selectedCurrentAmount = Convert.ToInt32(row.Cells[6].Value);
                    minRestockAmount = Convert.ToInt32(row.Cells[3].Value);
                    selectedPrice = Convert.ToDouble(row.Cells[4].Value);
                    selectedRow = row;

                    textBoxAmount_TextChanged(null, null);
                }
            }
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            Hide();
            parentWindow.Show();
            inventoryWindow.clearState();
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            if (!hasValidRestockAmount)
            {
                return;
            }

            string expirationDate = dtpExpiration.Value.ToShortDateString();
            int add_amount;
            try {
                add_amount = Convert.ToInt32(textBoxAmount.Text);
            } catch (Exception ex) {
                MessageBox.Show("Invalid restock amount.");
                return;
            }

            {
                int amount = Convert.ToInt32(textBoxAmount.Text);
                double total = selectedPrice * amount;
                RestockTotal.increase(total);
            }

            String purchaseDate = DateTime.Now.ToShortDateString();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE BakeTrack_Inventory SET quantity=@quantity, purchase_date=@purchase_date," +
                                            "last_updated=@last_updated, expiration_date=@expiration_date, total_cost=@total_cost WHERE id=@id", conn);

            int quantity = selectedCurrentAmount + add_amount;
            double total_cost = Math.Round(Convert.ToDouble(quantity) * selectedPrice, 2);

            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@purchase_date", DateTime.Parse(purchaseDate));
            cmd.Parameters.AddWithValue("@last_updated", DateTime.Parse(purchaseDate));
            cmd.Parameters.AddWithValue("@expiration_date", DateTime.Parse(expirationDate));
            cmd.Parameters.AddWithValue("@total_cost", total_cost);
            cmd.Parameters.AddWithValue("@id", selectedId);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            dataGridView.Rows.Remove(selectedRow);

            selectedId = -1;
            clearText();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            hasValidRestockAmount = false;
            if (selectedId >= 0)
            {
                try
                {
                    int amount = Convert.ToInt32(textBoxAmount.Text);
                    if (amount < minRestockAmount)
                    {
                        labelTotalCost.Text = "Amount to restock should be more\r\nthan " + amount + "!";
                        return;
                    }
                    double total = selectedPrice * amount;
                    hasValidRestockAmount = true;
                    labelTotalCost.Text = total.ToString();
                } catch (Exception ex)
                {
                    labelTotalCost.Text = " --- ";
                }
            }
        }
    }
}
