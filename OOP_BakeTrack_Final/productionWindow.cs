using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BakeTrack_Final
{
    public partial class productionWindow : Form
    {
        inventoryWindow inventoryWindow;
        mainWindow mainWindow;


        public productionWindow()
        {
            InitializeComponent();
        }

        private void restock_Click(object sender, EventArgs e)
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

        private void production_Click(object sender, EventArgs e)
        {

        }
    }
}
