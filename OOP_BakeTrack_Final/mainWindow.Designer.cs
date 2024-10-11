namespace OOP_BakeTrack_Final
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inventory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.production = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.breadPic = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadPic)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Location = new System.Drawing.Point(0, 41);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(182, 662);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(0, 662);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 171);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.welcome);
            this.panel7.Location = new System.Drawing.Point(2, 177);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 24);
            this.panel7.TabIndex = 8;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(44, 1);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(97, 19);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome User!";
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(2, 205);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 37);
            this.panel8.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.home);
            this.panel2.Location = new System.Drawing.Point(2, 246);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 52);
            this.panel2.TabIndex = 3;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.home.CausesValidation = false;
            this.home.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(-10, -4);
            this.home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.home.Size = new System.Drawing.Size(312, 63);
            this.home.TabIndex = 0;
            this.home.Text = "             Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inventory);
            this.panel3.Location = new System.Drawing.Point(2, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 63);
            this.panel3.TabIndex = 4;
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.inventory.CausesValidation = false;
            this.inventory.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.inventory.Image = ((System.Drawing.Image)(resources.GetObject("inventory.Image")));
            this.inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.Location = new System.Drawing.Point(-8, -11);
            this.inventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.inventory.Size = new System.Drawing.Size(312, 84);
            this.inventory.TabIndex = 0;
            this.inventory.Text = "             Inventory";
            this.inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.production);
            this.panel4.Location = new System.Drawing.Point(2, 369);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 63);
            this.panel4.TabIndex = 5;
            // 
            // production
            // 
            this.production.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.production.CausesValidation = false;
            this.production.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.production.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.production.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.production.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.production.Image = ((System.Drawing.Image)(resources.GetObject("production.Image")));
            this.production.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.production.Location = new System.Drawing.Point(-8, -11);
            this.production.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.production.Name = "production";
            this.production.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.production.Size = new System.Drawing.Size(312, 84);
            this.production.TabIndex = 0;
            this.production.Text = "             Production";
            this.production.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.production.UseVisualStyleBackColor = false;
            this.production.Click += new System.EventHandler(this.production_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.menuButton);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1318, 40);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1249, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1281, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(26, -1);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(41, 40);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // breadPic
            // 
            this.breadPic.Image = ((System.Drawing.Image)(resources.GetObject("breadPic.Image")));
            this.breadPic.Location = new System.Drawing.Point(0, 35);
            this.breadPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breadPic.Name = "breadPic";
            this.breadPic.Size = new System.Drawing.Size(1329, 861);
            this.breadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.breadPic.TabIndex = 8;
            this.breadPic.TabStop = false;
            this.breadPic.Click += new System.EventHandler(this.breadPic_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 661);
            this.Controls.Add(this.breadPic);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button production;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox breadPic;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}