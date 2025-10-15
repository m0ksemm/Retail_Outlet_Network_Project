namespace RONApp
{
    partial class UpdCatButton
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdCatButton));
            menuStrip1 = new MenuStrip();
            storesToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            AddCategButton = new Button();
            button2 = new Button();
            btnUpdCateg = new Button();
            btnProductAdd = new Button();
            btnProductDelete = new Button();
            btnProductUpdate = new Button();
            btnStoreAdd = new Button();
            btnStoreDelete = new Button();
            btnStoreUpdate = new Button();
            showAllProducts = new Button();
            showAllSales = new Button();
            btnRoleAdd = new Button();
            btnRoleDelete = new Button();
            btnRoleUpdate = new Button();
            btnUserAdd = new Button();
            btnUserUpdate = new Button();
            btnUserDelete = new Button();
            btnAddOperation = new Button();
            btnDeleteOperation = new Button();
            prodExpExc = new Button();
            btnExportCategoriesExcl = new Button();
            storesExpExc = new Button();
            allSalesInfo = new Button();
            prodhtml = new Button();
            categhtml = new Button();
            storesexp = new Button();
            allsaleshtml = new Button();
            numberOfCateg = new Label();
            numberOfProd = new Label();
            numberOfStores = new Label();
            numberOfUsers = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            numberOfOps = new Label();
            logoutBtn = new Button();
            user = new Label();
            login = new Button();
            username = new Label();
            password = new Label();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { storesToolStripMenuItem, operationsToolStripMenuItem, productsToolStripMenuItem, categoriesToolStripMenuItem, reportsToolStripMenuItem, rolesToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1276, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // storesToolStripMenuItem
            // 
            storesToolStripMenuItem.CheckOnClick = true;
            storesToolStripMenuItem.Enabled = false;
            storesToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            storesToolStripMenuItem.Size = new Size(101, 41);
            storesToolStripMenuItem.Text = "Stores";
            storesToolStripMenuItem.Click += storesToolStripMenuItem_Click;
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.CheckOnClick = true;
            operationsToolStripMenuItem.Enabled = false;
            operationsToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(160, 41);
            operationsToolStripMenuItem.Text = "Operations";
            operationsToolStripMenuItem.Click += operationsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.CheckOnClick = true;
            productsToolStripMenuItem.Enabled = false;
            productsToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(132, 41);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.CheckOnClick = true;
            categoriesToolStripMenuItem.Enabled = false;
            categoriesToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(156, 41);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.CheckOnClick = true;
            reportsToolStripMenuItem.Enabled = false;
            reportsToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(119, 41);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.CheckOnClick = true;
            rolesToolStripMenuItem.Enabled = false;
            rolesToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(92, 41);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.CheckOnClick = true;
            usersToolStripMenuItem.Enabled = false;
            usersToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(93, 41);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 14.75F);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1252, 671);
            dataGridView1.TabIndex = 1;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddCategButton
            // 
            AddCategButton.Font = new Font("Microsoft Sans Serif", 14.25F);
            AddCategButton.Location = new Point(12, 83);
            AddCategButton.Name = "AddCategButton";
            AddCategButton.Size = new Size(192, 45);
            AddCategButton.TabIndex = 2;
            AddCategButton.Text = "Add Category";
            AddCategButton.UseVisualStyleBackColor = true;
            AddCategButton.Visible = false;
            AddCategButton.Click += AddCategButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 14.25F);
            button2.Location = new Point(223, 82);
            button2.Name = "button2";
            button2.Size = new Size(168, 45);
            button2.TabIndex = 3;
            button2.Text = "Delete Category";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // btnUpdCateg
            // 
            btnUpdCateg.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnUpdCateg.Location = new Point(408, 83);
            btnUpdCateg.Name = "btnUpdCateg";
            btnUpdCateg.Size = new Size(199, 45);
            btnUpdCateg.TabIndex = 4;
            btnUpdCateg.Text = "Update Category";
            btnUpdCateg.UseVisualStyleBackColor = true;
            btnUpdCateg.Visible = false;
            btnUpdCateg.Click += btnUpdCateg_Click;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnProductAdd.Location = new Point(12, 82);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(192, 45);
            btnProductAdd.TabIndex = 5;
            btnProductAdd.Text = "Add Product";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Visible = false;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnProductDelete.Location = new Point(223, 82);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(168, 46);
            btnProductDelete.TabIndex = 6;
            btnProductDelete.Text = "Delete Product";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Visible = false;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnProductUpdate.Location = new Point(408, 83);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(199, 46);
            btnProductUpdate.TabIndex = 7;
            btnProductUpdate.Text = "Update Product";
            btnProductUpdate.UseVisualStyleBackColor = true;
            btnProductUpdate.Visible = false;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // btnStoreAdd
            // 
            btnStoreAdd.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnStoreAdd.Location = new Point(12, 83);
            btnStoreAdd.Name = "btnStoreAdd";
            btnStoreAdd.Size = new Size(192, 44);
            btnStoreAdd.TabIndex = 8;
            btnStoreAdd.Text = "Add Store";
            btnStoreAdd.UseVisualStyleBackColor = true;
            btnStoreAdd.Visible = false;
            btnStoreAdd.Click += btnStoreAdd_Click;
            // 
            // btnStoreDelete
            // 
            btnStoreDelete.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnStoreDelete.Location = new Point(223, 82);
            btnStoreDelete.Name = "btnStoreDelete";
            btnStoreDelete.Size = new Size(168, 46);
            btnStoreDelete.TabIndex = 9;
            btnStoreDelete.Text = "Delete Store";
            btnStoreDelete.UseVisualStyleBackColor = true;
            btnStoreDelete.Visible = false;
            btnStoreDelete.Click += btnStoreDelete_Click;
            // 
            // btnStoreUpdate
            // 
            btnStoreUpdate.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnStoreUpdate.Location = new Point(408, 83);
            btnStoreUpdate.Name = "btnStoreUpdate";
            btnStoreUpdate.Size = new Size(199, 46);
            btnStoreUpdate.TabIndex = 10;
            btnStoreUpdate.Text = "Update Store";
            btnStoreUpdate.UseVisualStyleBackColor = true;
            btnStoreUpdate.Visible = false;
            btnStoreUpdate.Click += btnStoreUpdate_Click;
            // 
            // showAllProducts
            // 
            showAllProducts.Font = new Font("Microsoft Sans Serif", 14.25F);
            showAllProducts.Location = new Point(626, 83);
            showAllProducts.Name = "showAllProducts";
            showAllProducts.Size = new Size(212, 46);
            showAllProducts.TabIndex = 11;
            showAllProducts.Text = "Show All Products";
            showAllProducts.UseVisualStyleBackColor = true;
            showAllProducts.Visible = false;
            showAllProducts.Click += showAllProducts_Click;
            // 
            // showAllSales
            // 
            showAllSales.Font = new Font("Microsoft Sans Serif", 14.25F);
            showAllSales.Location = new Point(859, 83);
            showAllSales.Name = "showAllSales";
            showAllSales.Size = new Size(201, 46);
            showAllSales.TabIndex = 12;
            showAllSales.Text = "Show All Sales";
            showAllSales.UseVisualStyleBackColor = true;
            showAllSales.Visible = false;
            showAllSales.Click += showAllSales_Click;
            // 
            // btnRoleAdd
            // 
            btnRoleAdd.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnRoleAdd.Location = new Point(12, 82);
            btnRoleAdd.Name = "btnRoleAdd";
            btnRoleAdd.Size = new Size(192, 44);
            btnRoleAdd.TabIndex = 13;
            btnRoleAdd.Text = "Add Role";
            btnRoleAdd.UseVisualStyleBackColor = true;
            btnRoleAdd.Visible = false;
            btnRoleAdd.Click += btnRoleAdd_Click;
            // 
            // btnRoleDelete
            // 
            btnRoleDelete.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnRoleDelete.Location = new Point(223, 83);
            btnRoleDelete.Name = "btnRoleDelete";
            btnRoleDelete.Size = new Size(168, 45);
            btnRoleDelete.TabIndex = 14;
            btnRoleDelete.Text = "Update Role";
            btnRoleDelete.UseVisualStyleBackColor = true;
            btnRoleDelete.Visible = false;
            btnRoleDelete.Click += btnRoleDelete_Click;
            // 
            // btnRoleUpdate
            // 
            btnRoleUpdate.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnRoleUpdate.Location = new Point(408, 83);
            btnRoleUpdate.Name = "btnRoleUpdate";
            btnRoleUpdate.Size = new Size(199, 45);
            btnRoleUpdate.TabIndex = 15;
            btnRoleUpdate.Text = "Delete Role";
            btnRoleUpdate.UseVisualStyleBackColor = true;
            btnRoleUpdate.Visible = false;
            btnRoleUpdate.Click += btnRoleUpdate_Click;
            // 
            // btnUserAdd
            // 
            btnUserAdd.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnUserAdd.Location = new Point(12, 82);
            btnUserAdd.Name = "btnUserAdd";
            btnUserAdd.Size = new Size(192, 46);
            btnUserAdd.TabIndex = 16;
            btnUserAdd.Text = "Add User";
            btnUserAdd.UseVisualStyleBackColor = true;
            btnUserAdd.Visible = false;
            btnUserAdd.Click += btnUserAdd_Click;
            // 
            // btnUserUpdate
            // 
            btnUserUpdate.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnUserUpdate.Location = new Point(223, 84);
            btnUserUpdate.Name = "btnUserUpdate";
            btnUserUpdate.Size = new Size(168, 45);
            btnUserUpdate.TabIndex = 17;
            btnUserUpdate.Text = "Update User";
            btnUserUpdate.UseVisualStyleBackColor = true;
            btnUserUpdate.Visible = false;
            btnUserUpdate.Click += btnUserUpdate_Click;
            // 
            // btnUserDelete
            // 
            btnUserDelete.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnUserDelete.Location = new Point(408, 83);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(199, 45);
            btnUserDelete.TabIndex = 18;
            btnUserDelete.Text = "Delete User";
            btnUserDelete.UseVisualStyleBackColor = true;
            btnUserDelete.Visible = false;
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // btnAddOperation
            // 
            btnAddOperation.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnAddOperation.Location = new Point(12, 84);
            btnAddOperation.Name = "btnAddOperation";
            btnAddOperation.Size = new Size(192, 45);
            btnAddOperation.TabIndex = 19;
            btnAddOperation.Text = "Add Operation";
            btnAddOperation.UseVisualStyleBackColor = true;
            btnAddOperation.Visible = false;
            btnAddOperation.Click += btnAddOperation_Click;
            // 
            // btnDeleteOperation
            // 
            btnDeleteOperation.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnDeleteOperation.Location = new Point(223, 84);
            btnDeleteOperation.Name = "btnDeleteOperation";
            btnDeleteOperation.Size = new Size(199, 45);
            btnDeleteOperation.TabIndex = 21;
            btnDeleteOperation.Text = "Delete Operation";
            btnDeleteOperation.UseVisualStyleBackColor = true;
            btnDeleteOperation.Visible = false;
            btnDeleteOperation.Click += btnDeleteOperation_Click;
            // 
            // prodExpExc
            // 
            prodExpExc.Anchor = AnchorStyles.Bottom;
            prodExpExc.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            prodExpExc.Location = new Point(306, 451);
            prodExpExc.Name = "prodExpExc";
            prodExpExc.Size = new Size(257, 174);
            prodExpExc.TabIndex = 22;
            prodExpExc.Text = "Export Products .xslx";
            prodExpExc.UseVisualStyleBackColor = true;
            prodExpExc.Visible = false;
            prodExpExc.Click += button1_Click;
            // 
            // btnExportCategoriesExcl
            // 
            btnExportCategoriesExcl.Anchor = AnchorStyles.Bottom;
            btnExportCategoriesExcl.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnExportCategoriesExcl.Location = new Point(12, 451);
            btnExportCategoriesExcl.Name = "btnExportCategoriesExcl";
            btnExportCategoriesExcl.Size = new Size(277, 174);
            btnExportCategoriesExcl.TabIndex = 23;
            btnExportCategoriesExcl.Text = "Export Categories .xslx";
            btnExportCategoriesExcl.UseVisualStyleBackColor = true;
            btnExportCategoriesExcl.Visible = false;
            btnExportCategoriesExcl.Click += btnExportCategoriesExcl_Click;
            // 
            // storesExpExc
            // 
            storesExpExc.Anchor = AnchorStyles.Bottom;
            storesExpExc.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            storesExpExc.Location = new Point(587, 451);
            storesExpExc.Name = "storesExpExc";
            storesExpExc.Size = new Size(225, 174);
            storesExpExc.TabIndex = 24;
            storesExpExc.Text = "Export Stores .xslx";
            storesExpExc.UseVisualStyleBackColor = true;
            storesExpExc.Visible = false;
            storesExpExc.Click += storesExpExc_Click;
            // 
            // allSalesInfo
            // 
            allSalesInfo.Anchor = AnchorStyles.Bottom;
            allSalesInfo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            allSalesInfo.Location = new Point(829, 451);
            allSalesInfo.Name = "allSalesInfo";
            allSalesInfo.Size = new Size(231, 174);
            allSalesInfo.TabIndex = 25;
            allSalesInfo.Text = "All Sales Info .xslx";
            allSalesInfo.UseVisualStyleBackColor = true;
            allSalesInfo.Visible = false;
            allSalesInfo.Click += allSalesInfo_Click;
            // 
            // prodhtml
            // 
            prodhtml.Anchor = AnchorStyles.Bottom;
            prodhtml.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            prodhtml.Location = new Point(306, 641);
            prodhtml.Name = "prodhtml";
            prodhtml.Size = new Size(257, 174);
            prodhtml.TabIndex = 26;
            prodhtml.Text = "Export Products .html";
            prodhtml.UseVisualStyleBackColor = true;
            prodhtml.Visible = false;
            prodhtml.Click += prodhtml_Click;
            // 
            // categhtml
            // 
            categhtml.Anchor = AnchorStyles.Bottom;
            categhtml.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            categhtml.Location = new Point(12, 641);
            categhtml.Name = "categhtml";
            categhtml.Size = new Size(277, 174);
            categhtml.TabIndex = 27;
            categhtml.Text = "Export Categories .html";
            categhtml.UseVisualStyleBackColor = true;
            categhtml.Visible = false;
            categhtml.Click += categexp_Click;
            // 
            // storesexp
            // 
            storesexp.Anchor = AnchorStyles.Bottom;
            storesexp.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            storesexp.Location = new Point(587, 641);
            storesexp.Name = "storesexp";
            storesexp.Size = new Size(225, 174);
            storesexp.TabIndex = 28;
            storesexp.Text = "Export Stores .html";
            storesexp.UseVisualStyleBackColor = true;
            storesexp.Visible = false;
            storesexp.Click += storesexp_Click;
            // 
            // allsaleshtml
            // 
            allsaleshtml.Anchor = AnchorStyles.Bottom;
            allsaleshtml.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            allsaleshtml.Location = new Point(829, 641);
            allsaleshtml.Name = "allsaleshtml";
            allsaleshtml.Size = new Size(231, 174);
            allsaleshtml.TabIndex = 29;
            allsaleshtml.Text = "All Sales Info .html";
            allsaleshtml.UseVisualStyleBackColor = true;
            allsaleshtml.Visible = false;
            allsaleshtml.Click += button3_Click;
            // 
            // numberOfCateg
            // 
            numberOfCateg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            numberOfCateg.AutoSize = true;
            numberOfCateg.Font = new Font("Segoe UI", 28F);
            numberOfCateg.Location = new Point(12, 75);
            numberOfCateg.Name = "numberOfCateg";
            numberOfCateg.Size = new Size(121, 51);
            numberOfCateg.TabIndex = 30;
            numberOfCateg.Text = "label1";
            numberOfCateg.Visible = false;
            // 
            // numberOfProd
            // 
            numberOfProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            numberOfProd.AutoSize = true;
            numberOfProd.Font = new Font("Segoe UI", 28F);
            numberOfProd.Location = new Point(12, 144);
            numberOfProd.Name = "numberOfProd";
            numberOfProd.Size = new Size(121, 51);
            numberOfProd.TabIndex = 31;
            numberOfProd.Text = "label2";
            numberOfProd.Visible = false;
            // 
            // numberOfStores
            // 
            numberOfStores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            numberOfStores.AutoSize = true;
            numberOfStores.Font = new Font("Segoe UI", 28F);
            numberOfStores.Location = new Point(12, 211);
            numberOfStores.Name = "numberOfStores";
            numberOfStores.Size = new Size(121, 51);
            numberOfStores.TabIndex = 32;
            numberOfStores.Text = "label3";
            numberOfStores.Visible = false;
            // 
            // numberOfUsers
            // 
            numberOfUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            numberOfUsers.AutoSize = true;
            numberOfUsers.Font = new Font("Segoe UI", 28F);
            numberOfUsers.Location = new Point(12, 281);
            numberOfUsers.Name = "numberOfUsers";
            numberOfUsers.Size = new Size(121, 51);
            numberOfUsers.TabIndex = 33;
            numberOfUsers.Text = "label4";
            numberOfUsers.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1077, 641);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1077, 451);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // numberOfOps
            // 
            numberOfOps.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            numberOfOps.AutoSize = true;
            numberOfOps.Font = new Font("Segoe UI", 28F);
            numberOfOps.Location = new Point(12, 352);
            numberOfOps.Name = "numberOfOps";
            numberOfOps.Size = new Size(121, 51);
            numberOfOps.TabIndex = 37;
            numberOfOps.Text = "label5";
            numberOfOps.Visible = false;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logoutBtn.Location = new Point(1077, 96);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(187, 33);
            logoutBtn.TabIndex = 38;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Visible = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // user
            // 
            user.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            user.AutoSize = true;
            user.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            user.Location = new Point(1077, 45);
            user.Name = "user";
            user.Size = new Size(160, 24);
            user.TabIndex = 39;
            user.Text = "Username, Role";
            user.Visible = false;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            login.Font = new Font("Segoe UI", 20F);
            login.Location = new Point(358, 517);
            login.Name = "login";
            login.Size = new Size(598, 50);
            login.TabIndex = 40;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 28F);
            username.Location = new Point(358, 328);
            username.Name = "username";
            username.Size = new Size(199, 51);
            username.TabIndex = 41;
            username.Text = "Username:";
            // 
            // password
            // 
            password.AllowDrop = true;
            password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 28F);
            password.Location = new Point(358, 421);
            password.Name = "password";
            password.Size = new Size(185, 51);
            password.TabIndex = 42;
            password.Text = "Password:";
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordInput.Font = new Font("Segoe UI", 24F);
            passwordInput.Location = new Point(576, 422);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(380, 50);
            passwordInput.TabIndex = 43;
            // 
            // usernameInput
            // 
            usernameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameInput.Font = new Font("Segoe UI", 24F);
            usernameInput.Location = new Point(576, 329);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(380, 50);
            usernameInput.TabIndex = 44;
            // 
            // UpdCatButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 827);
            Controls.Add(usernameInput);
            Controls.Add(passwordInput);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login);
            Controls.Add(user);
            Controls.Add(logoutBtn);
            Controls.Add(numberOfOps);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(numberOfUsers);
            Controls.Add(numberOfStores);
            Controls.Add(numberOfProd);
            Controls.Add(numberOfCateg);
            Controls.Add(allsaleshtml);
            Controls.Add(storesexp);
            Controls.Add(categhtml);
            Controls.Add(prodhtml);
            Controls.Add(allSalesInfo);
            Controls.Add(storesExpExc);
            Controls.Add(btnExportCategoriesExcl);
            Controls.Add(prodExpExc);
            Controls.Add(btnDeleteOperation);
            Controls.Add(btnAddOperation);
            Controls.Add(btnUserDelete);
            Controls.Add(btnUserUpdate);
            Controls.Add(btnUserAdd);
            Controls.Add(btnRoleUpdate);
            Controls.Add(btnRoleDelete);
            Controls.Add(btnRoleAdd);
            Controls.Add(showAllSales);
            Controls.Add(showAllProducts);
            Controls.Add(btnStoreUpdate);
            Controls.Add(btnStoreDelete);
            Controls.Add(btnStoreAdd);
            Controls.Add(btnProductUpdate);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductAdd);
            Controls.Add(btnUpdCateg);
            Controls.Add(button2);
            Controls.Add(AddCategButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UpdCatButton";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem storesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button AddCategButton;
        private Button button2;
        private Button btnUpdCateg;
        private Button btnProductAdd;
        private Button btnProductDelete;
        private Button btnProductUpdate;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private Button btnStoreAdd;
        private Button btnStoreDelete;
        private Button btnStoreUpdate;
        private Button showAllProducts;
        private Button showAllSales;
        private Button btnRoleAdd;
        private Button btnRoleDelete;
        private Button btnRoleUpdate;
        private Button btnUserAdd;
        private Button btnUserUpdate;
        private Button btnUserDelete;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Button btnAddOperation;
        private Button btnDeleteOperation;
        private Button prodExpExc;
        private Button btnExportCategoriesExcl;
        private Button storesExpExc;
        private Button allSalesInfo;
        private Button prodhtml;
        private Button categhtml;
        private Button storesexp;
        private Button allsaleshtml;
        private Label numberOfCateg;
        private Label numberOfProd;
        private Label numberOfStores;
        private Label numberOfUsers;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label numberOfOps;
        private Button logoutBtn;
        private Label user;
        private Button login;
        private Label username;
        private Label password;
        private TextBox passwordInput;
        private TextBox usernameInput;
    }
}
