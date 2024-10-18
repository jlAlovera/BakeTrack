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
        private shoppingListWindow shoppingListWindow;


        private mainWindow _mainWindow;  

        public inventoryWindow(mainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow; // Assign the reference
            refreshTable();
            updateRestockLabel();


            this.Width = 1764;
            this.Height = 802;
        }

        public void clearState()
        {
            selectedId = -1;
            selectedRow = null;
            dataGridView.ClearSelection();

            clearFields();

            refreshTable();
            updateRestockLabel();
        }

        public inventoryWindow()
        {
            InitializeComponent();
            refreshTable();

            this.Width = 1776; 
            this.Height =846;
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

        private void updateRestockLabel()
        {
            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name, quantity, reorder_level, category, purchase_date, expiration_date FROM BakeTrack_Inventory", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int restock_num = 0;
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[1]) < Convert.ToInt32(reader[2]))
                {
                    restock_num++;
                }
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();

            shoppingList.Text = restock_num.ToString();
        }

        private void refreshTable()
        {
            searchTable(null, null);
        }

        private void searchTable(string shouldCnt, string category)
        {
            dataGridView.Rows.Clear();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BakeTrack_Inventory ORDER BY id", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (category != null && !category.Equals("Any Ingredient") && !reader[2].ToString().Equals(category))
                {
                    continue;
                }
                if ((shouldCnt != null && shouldCnt.Trim().Length > 0 && !reader[1].ToString().ToLower().Contains(shouldCnt.Trim().ToLower())))
                {
                    continue;
                }
                dataGridView.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[4].ToString(),
                    reader[3].ToString(),
                    reader[5].ToString(),
                    ((DateTime)reader[6]).ToShortDateString(),
                    ((DateTime)reader[7]).ToShortDateString(),
                    String.Format("{0:0.00}", reader[8]));
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        private void clearFields()
        {
            textBoxName.Text = "";
            textBoxQuantity.Text = "";
            comboxCategory.Text = "Wet Ingredient";
            textBoxMeasureUnit.Text = "";
            textBoxCost.Text = "";
            textBoxReorder.Text = "";
            dtpExpiration.Value = DateTime.Now;
            dtpPurchase.Value = DateTime.Now;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {

            string name = Util.checkValidName(textBoxName.Text);

            if (Util.checkIfNameExists("BakeTrack_Inventory", name))
            {
                MessageBox.Show("Name already exists! Please try another one.");
                return;
            }

            int quantity;
            try
            {
                quantity = Convert.ToInt32(textBoxQuantity.Text); 
                if (quantity <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid quantity.");
                return;
            }
            string measure_unit = Util.checkValidName(textBoxMeasureUnit.Text);
            double cost;
            try
            {
                cost = Math.Round(Convert.ToDouble(textBoxCost.Text), 2);
                if (cost <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid cost.");
                return;
            }
            int reorder_lvl;
            try
            {
                reorder_lvl = Convert.ToInt32(textBoxReorder.Text);
                if (reorder_lvl <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid re-order level.");
                return;
            }

            string expirationDate = dtpExpiration.Value.ToShortDateString();
            string purchaseDate = dtpPurchase.Value.ToShortDateString();

            int id = Connection.getVacantID("BakeTrack_Inventory");

            string category = comboxCategory.Text;
            double total_cost = Math.Round(Convert.ToDouble(quantity) * cost, 2);

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO BakeTrack_Inventory" +
                                            "(id, name, category, quantity, measurement, reorder_level, purchase_date, expiration_date, cost_per_unit, total_cost, last_updated) " +
                                            "VALUES (@id, @name, @category, @quantity, @measure_unit, @reorder_lvl, @purchase_date, @expiration_date, @cost_per_unit, @total_cost, @last_updated)", conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@measure_unit", measure_unit);
            cmd.Parameters.AddWithValue("@reorder_lvl", reorder_lvl);
            cmd.Parameters.AddWithValue("@purchase_date", DateTime.Parse(purchaseDate));
            cmd.Parameters.AddWithValue("@expiration_date", DateTime.Parse(expirationDate));
            cmd.Parameters.AddWithValue("@cost_per_unit", cost);
            cmd.Parameters.AddWithValue("@total_cost", total_cost);
            cmd.Parameters.AddWithValue("@last_updated", DateTime.Parse(purchaseDate));

            cmd.ExecuteNonQuery();
            conn.Close();

            selectedId = -1;
            refreshTable();
            clearFields();
            updateRestockLabel();

            } catch (Exception ex)
            {
                MessageBox.Show("Error in adding inventory. Please check your input.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedId <= 0 | selectedRow == null)
                {
                    MessageBox.Show("Please select a valid ingredient first!");
                    return;
                }

                string name = Util.checkValidName(textBoxName.Text);

                if (!Util.checkNameChangeValid("BakeTrack_Inventory", name, selectedId))
                {
                    MessageBox.Show("Name already exists! Please try another one.");
                    return;
                }

                int quantity;
                try
                {
                    quantity = Convert.ToInt32((string)textBoxQuantity.Text);
                    if (quantity <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Invalid quantity."); return; }
                string measure_unit = Util.checkValidName(textBoxMeasureUnit.Text);
                double cost;
                try
                {
                    cost = Math.Round(Convert.ToDouble((string)textBoxCost.Text), 2);
                    if (cost <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Invalid cost."); return; }
                int reorder_lvl;
                try
                {
                    reorder_lvl = Convert.ToInt32((string)textBoxReorder.Text);
                    if (reorder_lvl <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Invalid re-order level."); return; }

                string expirationDate = dtpExpiration.Value.ToShortDateString();
                string purchaseDate = dtpPurchase.Value.ToShortDateString();
                string category = Util.checkValidName(comboxCategory.Text);

                double total_cost = Math.Round(Convert.ToDouble(quantity) * cost, 2);

                SqlConnection conn = Connection.getConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE BakeTrack_Inventory SET name=@name, quantity=@quantity, category=@category, measurement=@measurement, reorder_level=@reorder_level, purchase_date=@purchase_date," +
                                                "last_updated=@last_updated, expiration_date=@expiration_date, cost_per_unit=@cost_per_unit, total_cost=@total_cost WHERE id=@id", conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@measurement", measure_unit);
                cmd.Parameters.AddWithValue("@reorder_level", reorder_lvl);
                cmd.Parameters.AddWithValue("@purchase_date", DateTime.Parse(purchaseDate));
                cmd.Parameters.AddWithValue("@last_updated", DateTime.Parse(purchaseDate));
                cmd.Parameters.AddWithValue("@expiration_date", DateTime.Parse(expirationDate));
                cmd.Parameters.AddWithValue("@cost_per_unit", cost);
                cmd.Parameters.AddWithValue("@total_cost", total_cost);
                cmd.Parameters.AddWithValue("@id", selectedId);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();

                selectedRow.Cells[0].Value = selectedId;
                selectedRow.Cells[1].Value = name;
                selectedRow.Cells[2].Value = category;
                selectedRow.Cells[3].Value = measure_unit;
                selectedRow.Cells[4].Value = quantity;
                selectedRow.Cells[5].Value = reorder_lvl;
                selectedRow.Cells[6].Value = purchaseDate;
                selectedRow.Cells[7].Value = expirationDate;
                selectedRow.Cells[8].Value = String.Format("{0:0.00}", cost);

                selectedId = -1;
                clearFields();
                updateRestockLabel();

            } catch (Exception ex)
            {
                MessageBox.Show("Error in editing inventory. Please check your input.");
            }
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
            SqlCommand cmd = new SqlCommand("DELETE FROM BakeTrack_Inventory WHERE id=" + selectedId, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            updateRestockLabel();
            selectedId = -1;
            clearFields();
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
                    selectedId = Convert.ToInt32(row.Cells[0].Value);
                    textBoxName.Text = row.Cells[1].Value.ToString();
                    comboxCategory.Text = row.Cells[2].Value.ToString();
                    textBoxMeasureUnit.Text = row.Cells[3].Value.ToString();
                    textBoxQuantity.Text = row.Cells[4].Value.ToString();
                    textBoxReorder.Text = row.Cells[5].Value.ToString();
                    dtpPurchase.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                    dtpExpiration.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                    textBoxCost.Text = row.Cells[8].Value.ToString();

                    selectedRow = row;
                }
            }
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectedId = -1;
                clearFields();
                Console.WriteLine($"Search {search.Text}");
                searchTable(search.Text, comboxSearchCategory.Text);
                search.Text = "";
            }
        }

        private void dtpExpiration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reorder_Click(object sender, EventArgs e)
        {

        }

        private void textBoxReorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void purchaseDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpPurchase_ValueChanged(object sender, EventArgs e)
        {

        }

        private void expirationDate_Click(object sender, EventArgs e)
        {

        }

        private void inventoryWindow_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBoxShopping_click(object sender, EventArgs e)
        {
            // Ensure shoppingListWindow is instantiated
            if (shoppingListWindow == null)
            {
                shoppingListWindow = new shoppingListWindow(_mainWindow, this); // Initialize it if it's null
                shoppingListWindow.FormClosed += ShoppingWindowList_FormClosed; // Handle form closed event
            } else { 
                shoppingListWindow.clearState();
            }

            shoppingListWindow.Show(); // Show the shopping list window
            _mainWindow.hideMainWindow(); // Hide the main window
        }

        public void ShoppingWindowList_FormClosed(Object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void comboxSearchCategory_TextChanged(object sender, EventArgs e)
        {
            selectedId = -1;
            clearFields();
            Console.WriteLine($"Search {search.Text}");
            searchTable(search.Text, comboxSearchCategory.Text);
            search.Text = "";
        }
    }
}
