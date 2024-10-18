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
using System.IO;

namespace OOP_BakeTrack_Final
{
    public partial class productionWindow : Form
    {
        inventoryWindow inventoryWindow;
        mainWindow mainWindow;

        private int selectedId;
        private DataGridViewRow selectedRow = null;

        public productionWindow()
        {
            InitializeComponent();
            refreshTable();

            this.Width = 1766;
            this.Height = 807;
        }

        public void clearState()
        {
            dataGridView.ClearSelection();
            selectedRow = null;
            selectedId = -1;
            refreshTable();
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

        public void refreshTable()
        {
            dataGridView.Rows.Clear();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BakeTrack_Products ORDER BY id", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    String.Format("{0:0.00}", ((double) reader[3])),
                    ((DateTime)reader[4]).ToShortDateString(),
                    String.Format("{0:0.00}", ((double)reader[5])));
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }
        private void home_Click(object sender, EventArgs e)
        {
            if (mainWindow == null)
            {
                mainWindow = new mainWindow();
                mainWindow.FormClosed += Inventory_FormClosed;
                mainWindow.MdiParent = this;
                mainWindow.Show();
            }
            else
            {
                mainWindow.Activate();
            }
        }

        private void Inventory_FormClosed(Object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (inventoryWindow == null)
            {
                inventoryWindow = new inventoryWindow();
                inventoryWindow.FormClosed += Inventory_FormClosed;
                inventoryWindow.MdiParent = this;
                inventoryWindow.Show();
            }
            else
            {
                inventoryWindow.Activate();
            }
        }

        private (string, int, double) getFieldValues()
        {
            try
            {
                Util.checkValidName(textBoxName.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid name!");
                throw new Exception();
            }
            if (textBoxName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name should not be empty!");
                throw new Exception();
            }
            uint quantity;
            try
            {
                quantity = Convert.ToUInt32(textBoxQuantity.Text);
                if (quantity <= 0)
                {
                    throw new Exception();
                }
            } catch (Exception e)
            {
                MessageBox.Show("Invalid quantity.");
                throw new Exception();
            }
            double price;
            try
            {
                price = Math.Round(Convert.ToDouble(textBoxPrice.Text), 2);
                if (price <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid price.");
                throw new Exception();
            }
            return (textBoxName.Text, (int) quantity, price);
        }

        private void production_Click(object sender, EventArgs e)
        {
        }

        private void productionWindow_Load(object sender, EventArgs e)
        {

        }

        private void updatePriceLabel()
        {
            try
            {
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                if (quantity <= 0)
                {
                    throw new Exception();
                }
                double price = Math.Round(Convert.ToDouble(textBoxPrice.Text), 2);
                if (price <= 0)
                {
                    throw new Exception();
                }
                double total_price = Math.Round(price * quantity, 2);
                if (total_price <= 0)
                {
                    throw new Exception();
                }
                labelTotalCost.Text = " ₱" + String.Format("{0:0.00}", total_price);
            }
            catch (Exception ex) {
                labelTotalCost.Text = " --- ";
            }
        }

        private void clearFields()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            labelTotalCost.Text = " ₱0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name; int quantity; double price;
            try
            {
                (name, quantity, price) = getFieldValues();
            }
            catch (Exception ex) {
                return;
            }

            if (Util.checkIfNameExists("BakeTrack_Products", name))
            {
                MessageBox.Show("Name already exists! Please try another one.");
                return;
            }

            int id = Connection.getVacantID("BakeTrack_Products");

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO BakeTrack_Products" +
                                        "(id, name, quantity, price, date_produced, total_price)" +
                                        "VALUES (@id, @name, @quantity, @price, @date_produced, @total_price)", conn);

            double total_price = Math.Round(quantity * price, 2);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@date_produced", DateTime.Parse(DateTime.Now.ToString()));
            cmd.Parameters.AddWithValue("@total_price", total_price);

            cmd.ExecuteNonQuery();
            conn.Close();

            selectedId = -1;
            refreshTable();
            clearFields();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedId <= 0 | selectedRow == null)
            {
                MessageBox.Show("Please select a valid product first!");
                return;
            }

            String name; int quantity; double price;
            try
            {
                (name, quantity, price) = getFieldValues();
            }
            catch (Exception ex)
            {
                return;
            }

            if (Util.checkNameChangeValid("BakeTrack_Products", name, selectedId))
            {
                MessageBox.Show("Name already exists! Please try another one.");
                return;
            }

            SqlConnection conn = Connection.getConn();
            conn.Open();

            double total_price = Math.Round(quantity * price, 2);

            SqlCommand cmd = new SqlCommand("UPDATE BakeTrack_Products SET name=@name, quantity=@quantity, " +
                                            "price=@price, total_price=@total_price WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@total_price", total_price);

            cmd.ExecuteNonQuery();
            conn.Close();

            selectedRow.Cells[1].Value = name;
            selectedRow.Cells[2].Value = quantity;
            selectedRow.Cells[3].Value = String.Format("{0:0.00}", price);
            selectedRow.Cells[5].Value = String.Format("{0:0.00}", total_price);

            updatePriceLabel();

            selectedId = -1;
            clearFields();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedId <= 0 | selectedRow == null)
            {
                MessageBox.Show("Please select a valid product first!");
                return;
            }
            dataGridView.Rows.Remove(selectedRow);

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM BakeTrack_Products WHERE id=" + selectedId, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            selectedId = -1;
            clearFields();
        }
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            updatePriceLabel();
        }
        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            updatePriceLabel();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            selectedId = -1;
            selectedRow = null;
            clearFields();
            if (rowCount > 0)
            {
                Console.WriteLine("Selected rows: " + rowCount);
                for (int i = 0; i < rowCount; i++)
                {
                    if (dataGridView.SelectedRows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    DataGridViewRow row = dataGridView.SelectedRows[i];
                    selectedId = Convert.ToInt32(row.Cells[0].Value);
                    textBoxName.Text = row.Cells[1].Value.ToString();
                    textBoxQuantity.Text = row.Cells[2].Value.ToString();
                    textBoxPrice.Text = row.Cells[3].Value.ToString();

                    updatePriceLabel();

                    selectedRow = row;
                }
            }
        }

        private void Login_window_Click(object sender, EventArgs e)
        {

        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String hold = "";

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name, quantity, price, total_price FROM BakeTrack_Products WHERE date_produced=@date_produced", conn);
            String datestr = DateTime.Now.ToShortDateString();
            cmd.Parameters.AddWithValue("@date_produced", DateTime.Parse(datestr));
            SqlDataReader reader = cmd.ExecuteReader();

            hold += datestr + "\r\n\r\n";

            while (reader.Read())
            {
                hold += "Name: " + reader[0].ToString() + "\r\n";
                hold += "Quantity: " + reader[1].ToString() + "\r\n";
                hold += "Price: " + String.Format("{0:0.00}", Convert.ToDouble(reader[2])) + "\r\n";
                hold += "Total Price: " + String.Format("{0:0.00}", Convert.ToDouble(reader[3])) + "\r\n";
                hold += "\r\n";
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();

            File.WriteAllText(sfd.FileName, hold);

            conn = Connection.getConn();
            conn.Open();

            string sql = "DELETE FROM BakeTrack_Products";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            clearState();
        }
    }
}
