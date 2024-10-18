namespace OOP_BakeTrack_Final
{
    partial class inventoryWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryWindow));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxReorder = new System.Windows.Forms.TextBox();
            this.expirationDate = new System.Windows.Forms.Label();
            this.purchaseDate = new System.Windows.Forms.Label();
            this.reorder = new System.Windows.Forms.Label();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxShopping = new System.Windows.Forms.PictureBox();
            this.shoppingList = new System.Windows.Forms.Label();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.costUnit = new System.Windows.Forms.Label();
            this.measurement = new System.Windows.Forms.Label();
            this.textBoxMeasureUnit = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxCategory = new System.Windows.Forms.ComboBox();
            this.Login_window = new System.Windows.Forms.Label();
            this.comboxSearchCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(157)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(157)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(108, 138);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(157)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1551, 370);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ingredient ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ingredient Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unit of Measurement";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Reorder Level";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 170;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Purchase Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Expiration Date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 170;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cost per Unit";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 170;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 551);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1549, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.Location = new System.Drawing.Point(1261, 580);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(273, 47);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEdit.Location = new System.Drawing.Point(1261, 651);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(273, 47);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.Location = new System.Drawing.Point(1261, 724);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(273, 49);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1080, 64);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(367, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(1157, 78);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 28);
            this.search.TabIndex = 40;
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.name.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.name.Location = new System.Drawing.Point(133, 574);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(58, 24);
            this.name.TabIndex = 42;
            this.name.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(133, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.White;
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.ForeColor = System.Drawing.Color.Black;
            this.textBoxQuantity.Location = new System.Drawing.Point(344, 686);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(243, 34);
            this.textBoxQuantity.TabIndex = 47;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(344, 569);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 34);
            this.textBoxName.TabIndex = 48;
            // 
            // textBoxReorder
            // 
            this.textBoxReorder.BackColor = System.Drawing.Color.White;
            this.textBoxReorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReorder.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReorder.ForeColor = System.Drawing.Color.Black;
            this.textBoxReorder.Location = new System.Drawing.Point(868, 633);
            this.textBoxReorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxReorder.Multiline = true;
            this.textBoxReorder.Name = "textBoxReorder";
            this.textBoxReorder.Size = new System.Drawing.Size(243, 34);
            this.textBoxReorder.TabIndex = 53;
            this.textBoxReorder.UseWaitCursor = true;
            this.textBoxReorder.TextChanged += new System.EventHandler(this.textBoxReorder_TextChanged);
            // 
            // expirationDate
            // 
            this.expirationDate.AutoSize = true;
            this.expirationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.expirationDate.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.expirationDate.Location = new System.Drawing.Point(692, 746);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(134, 24);
            this.expirationDate.TabIndex = 51;
            this.expirationDate.Text = "Expiration Date:";
            this.expirationDate.UseWaitCursor = true;
            this.expirationDate.Click += new System.EventHandler(this.expirationDate_Click);
            // 
            // purchaseDate
            // 
            this.purchaseDate.AutoSize = true;
            this.purchaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.purchaseDate.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.purchaseDate.Location = new System.Drawing.Point(692, 693);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(127, 24);
            this.purchaseDate.TabIndex = 50;
            this.purchaseDate.Text = "Purchase Date:";
            this.purchaseDate.UseWaitCursor = true;
            this.purchaseDate.Click += new System.EventHandler(this.purchaseDate_Click);
            // 
            // reorder
            // 
            this.reorder.AutoSize = true;
            this.reorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.reorder.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.reorder.Location = new System.Drawing.Point(692, 639);
            this.reorder.Name = "reorder";
            this.reorder.Size = new System.Drawing.Size(128, 24);
            this.reorder.TabIndex = 49;
            this.reorder.Text = "Re-order Level:";
            this.reorder.UseWaitCursor = true;
            this.reorder.Click += new System.EventHandler(this.reorder_Click);
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
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Location = new System.Drawing.Point(0, 47);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(243, 815);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(0, 815);
            this.sidebar.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 210);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.welcome);
            this.panel7.Location = new System.Drawing.Point(3, 216);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 30);
            this.panel7.TabIndex = 8;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(59, 1);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(122, 24);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome User!";
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 250);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 46);
            this.panel8.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.home);
            this.panel2.Location = new System.Drawing.Point(3, 300);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 64);
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
            this.home.Location = new System.Drawing.Point(-13, -5);
            this.home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.home.Size = new System.Drawing.Size(416, 78);
            this.home.TabIndex = 0;
            this.home.Text = "             Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inventory);
            this.panel3.Location = new System.Drawing.Point(3, 368);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 78);
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
            this.inventory.Location = new System.Drawing.Point(-11, -14);
            this.inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.inventory.Size = new System.Drawing.Size(416, 103);
            this.inventory.TabIndex = 0;
            this.inventory.Text = "             Inventory";
            this.inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.production);
            this.panel4.Location = new System.Drawing.Point(3, 450);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 78);
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
            this.production.Location = new System.Drawing.Point(-11, -14);
            this.production.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.production.Name = "production";
            this.production.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.production.Size = new System.Drawing.Size(416, 103);
            this.production.TabIndex = 0;
            this.production.Text = "             Production";
            this.production.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.production.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(3, 532);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 78);
            this.panel5.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.button4.CausesValidation = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-11, -11);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(416, 103);
            this.button4.TabIndex = 0;
            this.button4.Text = "             Salary";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxShopping
            // 
            this.pictureBoxShopping.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShopping.Image")));
            this.pictureBoxShopping.Location = new System.Drawing.Point(1480, 60);
            this.pictureBoxShopping.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxShopping.Name = "pictureBoxShopping";
            this.pictureBoxShopping.Size = new System.Drawing.Size(60, 69);
            this.pictureBoxShopping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShopping.TabIndex = 62;
            this.pictureBoxShopping.TabStop = false;
            this.pictureBoxShopping.Click += new System.EventHandler(this.pictureBoxShopping_click);
            // 
            // shoppingList
            // 
            this.shoppingList.AutoSize = true;
            this.shoppingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.shoppingList.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.shoppingList.Location = new System.Drawing.Point(1524, 53);
            this.shoppingList.Name = "shoppingList";
            this.shoppingList.Size = new System.Drawing.Size(20, 24);
            this.shoppingList.TabIndex = 63;
            this.shoppingList.Text = "0";
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Enabled = false;
            this.dtpPurchase.Location = new System.Drawing.Point(868, 694);
            this.dtpPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(240, 22);
            this.dtpPurchase.TabIndex = 64;
            this.dtpPurchase.ValueChanged += new System.EventHandler(this.dtpPurchase_ValueChanged);
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Location = new System.Drawing.Point(868, 746);
            this.dtpExpiration.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(240, 22);
            this.dtpExpiration.TabIndex = 65;
            this.dtpExpiration.ValueChanged += new System.EventHandler(this.dtpExpiration_ValueChanged);
            // 
            // costUnit
            // 
            this.costUnit.AutoSize = true;
            this.costUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.costUnit.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.costUnit.Location = new System.Drawing.Point(693, 582);
            this.costUnit.Name = "costUnit";
            this.costUnit.Size = new System.Drawing.Size(110, 24);
            this.costUnit.TabIndex = 52;
            this.costUnit.Text = "Cost per Unit:";
            this.costUnit.UseWaitCursor = true;
            // 
            // measurement
            // 
            this.measurement.AutoSize = true;
            this.measurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.measurement.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.measurement.Location = new System.Drawing.Point(133, 742);
            this.measurement.Name = "measurement";
            this.measurement.Size = new System.Drawing.Size(172, 24);
            this.measurement.TabIndex = 44;
            this.measurement.Text = "Unit of Measurement:";
            // 
            // textBoxMeasureUnit
            // 
            this.textBoxMeasureUnit.BackColor = System.Drawing.Color.White;
            this.textBoxMeasureUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMeasureUnit.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeasureUnit.ForeColor = System.Drawing.Color.Black;
            this.textBoxMeasureUnit.Location = new System.Drawing.Point(344, 738);
            this.textBoxMeasureUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMeasureUnit.Multiline = true;
            this.textBoxMeasureUnit.Name = "textBoxMeasureUnit";
            this.textBoxMeasureUnit.Size = new System.Drawing.Size(243, 34);
            this.textBoxMeasureUnit.TabIndex = 46;
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.Color.White;
            this.textBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCost.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.ForeColor = System.Drawing.Color.Black;
            this.textBoxCost.Location = new System.Drawing.Point(868, 574);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCost.Multiline = true;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(243, 34);
            this.textBoxCost.TabIndex = 54;
            this.textBoxCost.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(133, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboxCategory
            // 
            this.comboxCategory.FormattingEnabled = true;
            this.comboxCategory.Items.AddRange(new object[] {
            "Wet Ingredient",
            "Dry Ingredient",
            "Pastry Design"});
            this.comboxCategory.Location = new System.Drawing.Point(344, 634);
            this.comboxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxCategory.Name = "comboxCategory";
            this.comboxCategory.Size = new System.Drawing.Size(243, 24);
            this.comboxCategory.TabIndex = 67;
            this.comboxCategory.Text = "Wet Ingredient";
            // 
            // Login_window
            // 
            this.Login_window.AutoSize = true;
            this.Login_window.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(27)))), ((int)(((byte)(22)))));
            this.Login_window.Location = new System.Drawing.Point(111, 64);
            this.Login_window.Name = "Login_window";
            this.Login_window.Size = new System.Drawing.Size(358, 50);
            this.Login_window.TabIndex = 68;
            this.Login_window.Text = "Inventory Manangement";
            // 
            // comboxSearchCategory
            // 
            this.comboxSearchCategory.FormattingEnabled = true;
            this.comboxSearchCategory.Items.AddRange(new object[] {
            "Any Ingredient",
            "Wet Ingredient",
            "Dry Ingredient",
            "Pastry Design"});
            this.comboxSearchCategory.Location = new System.Drawing.Point(832, 81);
            this.comboxSearchCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboxSearchCategory.Name = "comboxSearchCategory";
            this.comboxSearchCategory.Size = new System.Drawing.Size(239, 24);
            this.comboxSearchCategory.TabIndex = 69;
            this.comboxSearchCategory.Text = "Any Ingredient";
            this.comboxSearchCategory.TextChanged += new System.EventHandler(this.comboxSearchCategory_TextChanged);
            // 
            // inventoryWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 831);
            this.Controls.Add(this.comboxSearchCategory);
            this.Controls.Add(this.Login_window);
            this.Controls.Add(this.comboxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpExpiration);
            this.Controls.Add(this.dtpPurchase);
            this.Controls.Add(this.shoppingList);
            this.Controls.Add(this.pictureBoxShopping);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxReorder);
            this.Controls.Add(this.costUnit);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.purchaseDate);
            this.Controls.Add(this.reorder);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxMeasureUnit);
            this.Controls.Add(this.measurement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1777, 831);
            this.MinimumSize = new System.Drawing.Size(1777, 831);
            this.Name = "inventoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryWindow";
            this.Load += new System.EventHandler(this.inventoryWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxReorder;
        private System.Windows.Forms.Label expirationDate;
        private System.Windows.Forms.Label purchaseDate;
        private System.Windows.Forms.Label reorder;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button production;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox pictureBoxShopping;
        private System.Windows.Forms.Label shoppingList;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Label costUnit;
        private System.Windows.Forms.Label measurement;
        private System.Windows.Forms.TextBox textBoxMeasureUnit;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label Login_window;
        private System.Windows.Forms.ComboBox comboxSearchCategory;
    }
}