using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_BakeTrack_Final
{
    public partial class mainWindow : Form
    {
        private const FormWindowState minimized = FormWindowState.Minimized;

        inventoryWindow inventoryWindow;
        productionWindow productionWindow;
        shoppingListWindow shoppingListWindow;

        public mainWindow()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            sidebarTimer.Interval = 14;

            updateDataGridViews();
            updateHeader();
        }

        private void updateHeader()
        {
            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name, quantity, price, total_price FROM BakeTrack_Products WHERE date_produced=@date_produced", conn);
            cmd.Parameters.AddWithValue("@date_produced", DateTime.Parse(DateTime.Now.ToShortDateString()));
            SqlDataReader reader = cmd.ExecuteReader();
            double total_price = 0.0;
            int varieties = 0;
            while (reader.Read())
            {
                double add = Convert.ToDouble(reader[3]);
                total_price += add;
                varieties++;
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();

            labelAmountProduced.Text = String.Format("{0:0.00}", total_price);
            labelVarieties.Text = varieties.ToString();

        }

        private void updateDataGridViews()
        {
            dataGridViewRestock.Rows.Clear();
            dataGridViewExpiration.Rows.Clear();

            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name, quantity, reorder_level, category, purchase_date, expiration_date FROM BakeTrack_Inventory", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[1]) < Convert.ToInt32(reader[2]))
                {
                    dataGridViewRestock.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString());
                }
                DateTime purchaseDate = DateTime.Parse(reader[4].ToString());
                DateTime expirationDate = DateTime.Parse(reader[5].ToString());

                long daysDifference = Convert.ToInt64(Math.Ceiling((expirationDate - purchaseDate).TotalDays));
                
                if (daysDifference <= 5)
                {
                    dataGridViewExpiration.Rows.Add(
                        reader[0].ToString(),
                        reader[3].ToString(),
                        ((DateTime)reader[5]).ToShortDateString());
                }
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); // Start the timer to expand/collapse the sidebar

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



        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void breadPic_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
           
            if (inventoryWindow != null)
            {
                inventoryWindow.Close();
                inventoryWindow = null;  
            }

            
            this.Activate();
            if (inventoryWindow != null)
                inventoryWindow.Hide();
            if (productionWindow != null)
                productionWindow.Hide();
            panelDashboard.Show();
            sidebarTimer.Start();

            updateDataGridViews();
            updateHeader();
        }

        private void Inventory_FormClosed(Object sender, FormClosedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (inventoryWindow == null)
            {
                inventoryWindow = new inventoryWindow(this);
                inventoryWindow.FormClosed += Inventory_FormClosed;
                inventoryWindow.MdiParent = this;
                inventoryWindow.Show();
                panelDashboard.Hide();
            }
            else
            {
                inventoryWindow.clearState();
                inventoryWindow.Activate();
            }
            if (productionWindow != null){
                productionWindow.Close();
                productionWindow = null;
            }
            sidebarTimer.Start();
        }

        private void Production_FormClosed(Object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void production_Click(object sender, EventArgs e)
        {
            
            if (productionWindow == null)
            {
                productionWindow = new productionWindow();
                productionWindow.FormClosed += Production_FormClosed;
                productionWindow.MdiParent = this;
                productionWindow.Show();
                panelDashboard.Hide();
            }
            else
            {
                productionWindow.clearState();
                productionWindow.Activate();
            }
            if (inventoryWindow != null){
                inventoryWindow.Close();
                inventoryWindow = null;
            }
            sidebarTimer.Start();
        }

        // Close button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        // Minimize button
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = minimized;
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void hideMainWindow()
        {
            this.Hide();
        }
    }
}
