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
        private int selectedId = -1;
        private DataGridViewRow selectedRow = null;
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
            searchTable(null);
        }

        private void searchTable(string shouldCnt)
        {
            dataGridView.Rows.Clear();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredients", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (shouldCnt != null && !reader[1].ToString().ToLower().Contains(shouldCnt.Trim().ToLower()))
                {
                    continue;
                }
                dataGridView.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString(),
                    reader[4].ToString(),
                    ((DateTime)reader[5]).ToShortDateString(),
                    ((DateTime)reader[6]).ToShortDateString(),
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

            Console.WriteLine(expirationDate + " " + purchaseDate);

            int id = Connection.getVacantID("Ingredients");

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ingredients(id, name, quantity, measurement_unit, reorder_level, purchase, expiration, cost_per_unit) VALUES (" +
                                            id + ", '" + name + "', " + quantity + ", '" + measure_unit + "', " + reorder_lvl + ", CAST('" + purchaseDate + "' AS Date), CAST('" + expirationDate + "' AS Date), CAST('" + cost + "' AS FLOAT))", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            selectedId = -1;
            refreshTable();
            clearFields();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedId <= 0 | selectedRow == null)
            {
                MessageBox.Show("Please select a valid ingredient first!");
                return;
            }

            string name = textBoxName.Text;
            int quantity;
            try
            {
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

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Ingredients SET name='" + name + "', quantity=" + quantity + ", measurement_unit='" + measure_unit + "', reorder_level=" + reorder_lvl + ", purchase=CAST('" + purchaseDate + "' AS Date), expiration=CAST('" + expirationDate + "' AS Date), cost_per_unit=CAST('" + cost + "' AS FLOAT) WHERE id=" + selectedId, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            selectedRow.Cells[0].Value = selectedId;
            selectedRow.Cells[1].Value = name;
            selectedRow.Cells[2].Value = quantity;
            selectedRow.Cells[3].Value = measure_unit;
            selectedRow.Cells[4].Value = reorder_lvl;
            selectedRow.Cells[5].Value = purchaseDate;
            selectedRow.Cells[6].Value = expirationDate;
            selectedRow.Cells[7].Value = cost;

            selectedId = -1;
            clearFields();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedId <= 0 | selectedRow == null)
            {
                MessageBox.Show("Please select a valid ingredient first!");
                return;
            }
            dataGridView.Rows.Remove(selectedRow);

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Ingredients WHERE id=" + selectedId, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            selectedId = -1;
            selectedRow = null;
            clearFields();
            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (dataGridView.SelectedRows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    DataGridViewRow row = dataGridView.SelectedRows[i];
                    Console.WriteLine(row.Cells[0].Value.ToString() + " " +
                                        row.Cells[1].Value.ToString() + " " +
                                        row.Cells[2].Value.ToString() + " " +
                                        row.Cells[3].Value.ToString() + " " +
                                        row.Cells[4].Value.ToString() + " " +
                                        row.Cells[5].Value.ToString() + " " +
                                        row.Cells[6].Value.ToString() + " " +
                                        row.Cells[7].Value.ToString());
                    selectedId = Convert.ToInt32(row.Cells[0].Value);
                    textBoxName.Text = row.Cells[1].Value.ToString();
                    textBoxQuantity.Text = row.Cells[2].Value.ToString();
                    textBoxMeasureUnit.Text = row.Cells[3].Value.ToString();
                    textBoxReorder.Text = row.Cells[4].Value.ToString();
                    dtpPurchase.Value = DateTime.ParseExact(row.Cells[5].Value.ToString(), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    dtpExpiration.Value = DateTime.ParseExact(row.Cells[6].Value.ToString(), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    textBoxCost.Text = row.Cells[7].Value.ToString();

                    selectedRow = row;
                }
            }
            else
            {
                Console.WriteLine("No rows selected.");
            }
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectedId = -1;
                clearFields();
                if (search.Text.Trim().Length == 0)
                {
                    refreshTable();
                    return;
                }
                Console.WriteLine($"Search {search.Text}");
                searchTable(search.Text);
                search.Text = "";
            }
        }
    }
}
