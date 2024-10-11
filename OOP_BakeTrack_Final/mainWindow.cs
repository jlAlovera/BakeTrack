using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BakeTrack_Final
{
    public partial class mainWindow : Form
    {
        private const FormWindowState minimized = FormWindowState.Minimized;

        inventoryWindow inventoryWindow;
        productionWindow productionWindow;

        public mainWindow()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            sidebarTimer.Interval = 14;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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
                breadPic.Left -= 20;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    sidebar.Width = sidebar.MinimumSize.Width;
                    breadPic.Left = sidebar.Right;
                }
            }
            else
            {
                sidebar.Width += 20;
                breadPic.Left += 20;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    sidebar.Width = sidebar.MaximumSize.Width;
                    breadPic.Left = sidebar.Right;
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
            breadPic.Visible = true;
            if (inventoryWindow != null)
            {
                inventoryWindow.Close();
                inventoryWindow = null;  
            }

            
            this.Activate();
            sidebarTimer.Start();
        }

        private void Inventory_FormClosed(Object sender, FormClosedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            breadPic.Visible = false;
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
            sidebarTimer.Start();
        }

        private void Production_FormClosed(Object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void production_Click(object sender, EventArgs e)
        {
            breadPic.Visible = false;
            if (productionWindow == null)
            {
                productionWindow = new productionWindow();
                productionWindow.FormClosed += Production_FormClosed;
                productionWindow.MdiParent = this;
                productionWindow.Show();
            }
            else
            {
                productionWindow.Activate();
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
    }
}
