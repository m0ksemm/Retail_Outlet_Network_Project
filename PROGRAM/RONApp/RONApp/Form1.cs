using System.CodeDom.Compiler;
using System.Data;
using OfficeOpenXml;
using RONApp.Models;
using RONApp.Repositories;

namespace RONApp
{
    public partial class UpdCatButton : Form
    {
        public UpdCatButton()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 30;
            this.Text = "Retail Outlet Network App";

            passwordInput.UseSystemPasswordChar = true;

        }

        private async void login_Click(object sender, EventArgs e)
        {
            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            string role = "";
            string name = "";

            foreach (User user in users) 
            {
                if (user.UserName == usernameInput.Text && user .PasswordHash == passwordInput.Text) 
                {
                    role = user.Role.RoleName;
                    name = user.UserFullName;
                    break;
                }
            }

            if (role == "")
            {
                MessageBox.Show("Invalid Login Or Password");
                return;
            }

            logoutBtn.Visible = true;
            user.Visible = true;

            user.Text = name + "\n" + role;
            if (role == "Administrator") 
            {
                storesToolStripMenuItem.Enabled = true;
                operationsToolStripMenuItem.Enabled = true;
                productsToolStripMenuItem.Enabled = true;
                categoriesToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
                rolesToolStripMenuItem.Enabled = true;
                usersToolStripMenuItem.Enabled = true;
            }
            else if (role == "Manager")
            {
                storesToolStripMenuItem.Enabled = true;
                operationsToolStripMenuItem.Enabled = true;
                productsToolStripMenuItem.Enabled = true;
                categoriesToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
            }
            else if (role == "Cashier") 
            {
                storesToolStripMenuItem.Enabled = true;
                operationsToolStripMenuItem.Enabled = true;
                productsToolStripMenuItem.Enabled = true;
            }

            username.Visible = false;
            password.Visible = false;
            usernameInput.Visible = false;
            passwordInput.Visible = false;
            login.Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //hide
            dataGridView1.Visible = false;
            AddCategButton.Visible = false;
            button2.Visible = false;
            btnUpdCateg.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            logoutBtn.Visible = false;
            user.Visible = false;

            storesToolStripMenuItem.Enabled = false;
            operationsToolStripMenuItem.Enabled = false;
            productsToolStripMenuItem.Enabled = false;
            categoriesToolStripMenuItem.Enabled = false;
            reportsToolStripMenuItem.Enabled = false;
            rolesToolStripMenuItem.Enabled = false;
            usersToolStripMenuItem.Enabled = false;

            username.Visible = true;
            password.Visible = true;
            usernameInput.Visible = true;
            passwordInput.Visible = true;
            login.Visible = true;
        }

        async Task ReadShowCategories()
        {
            CategoryRepository repository = new CategoryRepository();

            List<Category> categories = await repository.GetCategories();
            DataTable table = new DataTable();
            table.Columns.Add("Category ID");
            table.Columns.Add("Category name");
            for (int i = 0; i < categories.Count; i++)
            {
                table.Rows.Add(i + 1, categories[i].CategoryName);
            }

            dataGridView1.DataSource = table;
        }
        async Task ReadShowProducts()
        {
            ProductRepository repository = new ProductRepository();

            List<Product> products = await repository.GetProducts();
            DataTable table = new DataTable();
            table.Columns.Add("Product ID");
            table.Columns.Add("Product Name");
            table.Columns.Add("Category Name");
            table.Columns.Add("Price");
            table.Columns.Add("SKU");
            table.Columns.Add("Created At");

            for (int i = 0; i < products.Count; i++)
            {
                var row = table.NewRow();
                row["Product ID"] = i + 1;
                row["Product Name"] = products[i].ProductName;
                row["Category Name"] = products[i].Category.CategoryName;
                row["Price"] = products[i].Price;
                row["SKU"] = products[i].SKU;
                row["Created At"] = products[i].CreatedAt;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }

        async Task ReadShowStores()
        {
            StoreRepository storeRepository = new StoreRepository();

            List<Store> stores = await storeRepository.GetStores();
            DataTable table = new DataTable();
            table.Columns.Add("Store ID");
            table.Columns.Add("Store Name");
            table.Columns.Add("Address");
            table.Columns.Add("Created At");

            for (int i = 0; i < stores.Count; i++)
            {
                var row = table.NewRow();
                row["Store ID"] = i + 1;
                row["Store Name"] = stores[i].StoreName;
                row["Address"] = stores[i].Address;
                row["Created At"] = stores[i].CreatedAt;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }

        async Task ReadShowRoles()
        {
            RoleRepository rolesRepository = new RoleRepository();

            List<Role> roles = await rolesRepository.GetRoles();
            DataTable table = new DataTable();
            table.Columns.Add("Role ID");
            table.Columns.Add("Role Name");

            for (int i = 0; i < roles.Count; i++)
            {
                var row = table.NewRow();
                row["Role ID"] = i + 1;
                row["Role Name"] = roles[i].RoleName;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }
        async Task ReadShowUsers()
        {
            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            RoleRepository rolesRepository = new RoleRepository();
            List<Role> roles = await rolesRepository.GetRoles();

            DataTable table = new DataTable();
            table.Columns.Add("User ID");
            table.Columns.Add("Login");
            table.Columns.Add("Full Name");
            table.Columns.Add("Role");

            for (int i = 0; i < users.Count; i++)
            {
                var row = table.NewRow();
                row["User ID"] = i + 1;
                row["Login"] = users[i].UserName;
                row["Full Name"] = users[i].UserFullName;
                row["Role"] = roles.FirstOrDefault(temp => temp.RoleID == users[i].RoleID).RoleName;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }

        async Task ReadShowOperations()
        {
            SaleProductRepository spRepository = new SaleProductRepository();
            List<SaleProduct> sp = await spRepository.GetSaleProducts();

            DataTable table = new DataTable();
            table.Columns.Add("Operation ID");
            table.Columns.Add("Product");
            table.Columns.Add("Quantity");
            table.Columns.Add("Price");
            table.Columns.Add("Operation Date");

            for (int i = 0; i < sp.Count; i++)
            {
                var row = table.NewRow();
                row["Operation ID"] = i + 1;
                row["Product"] = sp[i].Product.ProductName;
                row["Quantity"] = sp[i].Quantity;
                row["Price"] = sp[i].Price;
                row["Operation Date"] = sp[i].Sale.CreatedAt;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }

        private async void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            AddCategButton.Visible = true;
            button2.Visible = true;
            btnUpdCateg.Visible = true;

            //hide
            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            await ReadShowCategories();
        }

        private async void AddCategButton_Click(object sender, EventArgs e)
        {
            CategoryCreateEditForm form = new CategoryCreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowCategories();
            }
        }

        private async void btnUpdCateg_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = await repository.GetCategories();

            Category c = new Category();
            c.CategoryID = categories[client_id - 1].CategoryID;
            c.CategoryName = categories[client_id - 1].CategoryName;

            CategoryCreateEditForm frm = new CategoryCreateEditForm();
            frm.EditCategory(c);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowCategories();
            }
        }



        private async void button2_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = await repository.GetCategories();

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this category?",
                "Delete Category", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteCategory(categories[client_id - 1].CategoryID);
            await ReadShowCategories();
        }

        private async void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;      // Вимикаються всі інші кнопки,
            AddCategButton.Visible = false;    // що не стосуються пункту меню
            button2.Visible = false;           // Products.
            btnUpdCateg.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            btnProductAdd.Visible = true;       // Активуються потрібні елементи 
            btnProductDelete.Visible = true;    
            btnProductUpdate.Visible = true;
                                                // Завантажуються потрібні дані та
            await ReadShowProducts();           // подаються у вигляді таблиці.
        }

        private async void btnProductAdd_Click(object sender, EventArgs e)
        {
            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = await repository.GetCategories();

            ProductCreateEditForm form = new ProductCreateEditForm(categories);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowProducts();
            }
        }

        private async void btnProductDelete_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            ProductRepository repository = new ProductRepository();
            List<Product> products = await repository.GetProducts();

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this product?",
                "Delete Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteProduct(products[client_id - 1].ProductID);
            await ReadShowProducts();
        }

        private async void btnProductUpdate_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            ProductRepository repository = new ProductRepository();
            List<Product> products = await repository.GetProducts();

            Product p = new Product();
            p.Category = new Category();

            p.ProductID = products[client_id - 1].ProductID;
            p.CategoryID = products[client_id - 1].CategoryID;
            p.ProductName = products[client_id - 1].ProductName;
            p.Price = products[client_id - 1].Price;
            p.SKU = products[client_id - 1].SKU;
            p.Category.CategoryName = products[client_id - 1].Category.CategoryName;

            CategoryRepository CatRepository = new CategoryRepository();
            List<Category> categories = await CatRepository.GetCategories();

            ProductCreateEditForm frm = new ProductCreateEditForm(categories);
            frm.EditProduct(p);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowProducts();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;


            //hide
            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            AddCategButton.Visible = false;
            button2.Visible = false;
            btnUpdCateg.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            //show
            btnStoreAdd.Visible = true;
            btnStoreDelete.Visible = true;
            btnStoreUpdate.Visible = true;

            showAllProducts.Visible = true;
            showAllSales.Visible = true;



            await ReadShowStores();
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private async void btnStoreAdd_Click(object sender, EventArgs e)
        {
            StoresCreateEditForm form = new StoresCreateEditForm(); 
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowStores();
            }
        }

        private async void btnStoreDelete_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            StoreRepository repository = new StoreRepository();
            List<Store> stores = await repository.GetStores();

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this store?",
                "Delete Store", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteStore(stores[client_id - 1].StoreID);
            await ReadShowStores();
        }

        private async void btnStoreUpdate_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            StoreRepository repository = new StoreRepository();
            List<Store> stores = await repository.GetStores();

            Store store = new Store();
            store.StoreID = stores[client_id - 1].StoreID;
            store.StoreName = stores[client_id - 1].StoreName;
            store.Address = stores[client_id - 1].Address;
            store.CreatedAt = stores[client_id - 1].CreatedAt;

            StoresCreateEditForm frm = new StoresCreateEditForm();
            frm.EditStore(store);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowStores();
            }
        }

        private async void showAllProducts_Click(object sender, EventArgs e)
        {    
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            StoreRepository repository = new StoreRepository();
            List<Store> stores = await repository.GetStores();

            InventoryStoreForm form = new InventoryStoreForm(stores[client_id - 1]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowStores();
            }
        }

        private async void showAllSales_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            StoreRepository repository = new StoreRepository();
            List<Store> stores = await repository.GetStores();

            SaleStoreForm form = new SaleStoreForm(stores[client_id - 1]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowStores();
            }
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hide
            dataGridView1.Visible = true;
            AddCategButton.Visible = false;
            button2.Visible = false;
            btnUpdCateg.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            //
            btnRoleAdd.Visible = true;
            btnRoleDelete.Visible = true;
            btnRoleUpdate.Visible = true;


            await ReadShowRoles();
        }

        private async void btnRoleAdd_Click(object sender, EventArgs e)
        {
            RoleCreateEditForm form = new RoleCreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowRoles();
            }
        }

        private async void btnRoleDelete_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            RoleRepository repository = new RoleRepository();
            List<Role> roles = await repository.GetRoles();

            Role role = new Role();
            role.RoleID = roles[client_id - 1].RoleID;
            role.RoleName = roles[client_id - 1].RoleName;

            RoleCreateEditForm frm = new RoleCreateEditForm();
            frm.EditRole(role);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowRoles();
            }
        }

        private async void btnRoleUpdate_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int role_id = int.Parse(val);
            RoleRepository repository = new RoleRepository();
            List<Role> roles = await repository.GetRoles();

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this role?",
                "Delete Roles", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteRole(roles[role_id - 1].RoleID);
            await ReadShowRoles();
        }

        private async void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide
            dataGridView1.Visible = true;
            AddCategButton.Visible = false;
            button2.Visible = false;
            btnUpdCateg.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            //show
            btnUserAdd.Visible = true;
            btnUserDelete.Visible = true;
            btnUserUpdate.Visible = true;

            await ReadShowUsers();
        }

        private async void btnUserAdd_Click(object sender, EventArgs e)
        {
            RoleRepository roleRepo = new RoleRepository();
            List<Role> roles = await roleRepo.GetRoles();

            UserCreateEditForm form = new UserCreateEditForm(roles);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowUsers();
            }
        }

        private async void btnUserUpdate_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            UsersRepository repository = new UsersRepository();
            List<User> users = await repository.GetUsers();

            User user = new User();
            user.Role = new Role();

            user.UserID = users[client_id - 1].UserID;
            user.UserFullName = users[client_id - 1].UserFullName;
            user.UserName = users[client_id - 1].UserName;
            user.PasswordHash = users[client_id - 1].PasswordHash;
            user.RoleID = users[client_id - 1].RoleID;
            user.Role.RoleName = users[client_id - 1].Role.RoleName;

            RoleRepository roleRepository = new RoleRepository();
            List<Role> roles = await roleRepository.GetRoles();

            UserCreateEditForm frm = new UserCreateEditForm(roles);
            frm.EditUser(user);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowUsers();
            }
        }

        private async void btnUserDelete_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            UsersRepository repository = new UsersRepository();
            List<User> products = await repository.GetUsers();

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this user?",
                "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteUser(products[client_id - 1].UserID);
            await ReadShowUsers();
        }

        private async void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide
            dataGridView1.Visible = true;
            AddCategButton.Visible = false;
            button2.Visible = false;
            btnUpdCateg.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnExportCategoriesExcl.Visible = false;
            prodExpExc.Visible = false;
            storesExpExc.Visible = false;
            allSalesInfo.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            prodhtml.Visible = false;
            categhtml.Visible = false;
            storesexp.Visible = false;
            allsaleshtml.Visible = false;

            numberOfCateg.Visible = false;
            numberOfProd.Visible = false;
            numberOfStores.Visible = false;
            numberOfUsers.Visible = false;
            numberOfOps.Visible = false;

            //show
            btnAddOperation.Visible = true;
            btnDeleteOperation.Visible = true;

            await ReadShowOperations();
        }

        private async void btnAddOperation_Click(object sender, EventArgs e)
        {
            ProductRepository productsRepository = new ProductRepository();
            List<Product> products = await productsRepository.GetProducts();

            SalesRepository salesRepository = new SalesRepository();
            List<Sale> sales = await salesRepository.GetSales();

            SaleProductRepository spRepository = new SaleProductRepository();
            List<SaleProduct> saleProducts = await spRepository.GetSaleProducts();

            List<Sale> freeSales = new List<Sale>();

            foreach (Sale s in sales)
            {
                bool flag = false;
                foreach (SaleProduct sp in saleProducts)
                {
                    if (sp.SaleID == s.SaleID)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    freeSales.Add(s);
                }
            }

            if (freeSales.Count == 0)
            {
                MessageBox.Show("There are no active sales at this moment\nPlease create a Sale firstly", "Ok");
                return;
            }

            OperationCreateEditForm form = new OperationCreateEditForm(products, freeSales);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowOperations();
            }
        }

        private async void btnDeleteOperation_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            SaleProductRepository repository = new SaleProductRepository();
            List<SaleProduct> sp = await repository.GetSaleProducts();

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this operation?",
                "Delete Operation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteSaleProduct(sp[client_id - 1].SaleProductID);
            await ReadShowOperations();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ProductRepository productsRepository = new ProductRepository();
            List<Product> products = await productsRepository.GetProducts();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfd.FileName = "Products.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("Products");

                        // Заголовки
                        ws.Cells[1, 1].Value = "ID";
                        ws.Cells[1, 2].Value = "Name";
                        ws.Cells[1, 3].Value = "Price";
                        ws.Cells[1, 4].Value = "SKU";
                        ws.Cells[1, 5].Value = "Category";

                        for (int i = 0; i < products.Count; i++)
                        {
                            var p = products[i];
                            ws.Cells[i + 2, 1].Value = i + 1;
                            ws.Cells[i + 2, 2].Value = p.ProductName;
                            ws.Cells[i + 2, 3].Value = p.Price;
                            ws.Cells[i + 2, 4].Value = p.SKU;
                            ws.Cells[i + 2, 5].Value = p.Category.CategoryName;
                        }

                        ws.Cells.AutoFitColumns();

                        // Зберігаємо в обраний файл
                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("File was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private async void btnExportCategoriesExcl_Click(object sender, EventArgs e)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = await categoryRepository.GetCategories();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfd.FileName = "Categories.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("Categories");

                        // Заголовки
                        ws.Cells[1, 1].Value = "ID";
                        ws.Cells[1, 2].Value = "Category Name";

                        for (int i = 0; i < categories.Count; i++)
                        {
                            var p = categories[i];
                            ws.Cells[i + 2, 1].Value = i + 1;
                            ws.Cells[i + 2, 2].Value = p.CategoryName;
                        }

                        ws.Cells.AutoFitColumns();

                        // Зберігаємо в обраний файл
                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("File was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void storesExpExc_Click(object sender, EventArgs e)
        {
            StoreRepository storeRepository = new StoreRepository();
            List<Store> stores = await storeRepository.GetStores();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfd.FileName = "Stores.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("Stores");

                        // Заголовки
                        ws.Cells[1, 1].Value = "ID";
                        ws.Cells[1, 2].Value = "Store Name";
                        ws.Cells[1, 3].Value = "Address";
                        ws.Cells[1, 4].Value = "Created At";

                        for (int i = 0; i < stores.Count; i++)
                        {
                            var p = stores[i];
                            ws.Cells[i + 2, 1].Value = i + 1;
                            ws.Cells[i + 2, 2].Value = p.StoreName;
                            ws.Cells[i + 2, 3].Value = p.Address;
                            ws.Cells[i + 2, 4].Value = p.CreatedAt.ToString();
                        }

                        ws.Cells.AutoFitColumns();

                        // Зберігаємо в обраний файл
                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("File was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void allSalesInfo_Click(object sender, EventArgs e)
        {
            StoreRepository storeRepository = new StoreRepository();
            List<Store> stores = await storeRepository.GetStores();

            ProductRepository productRepository = new ProductRepository();
            List<Product> products = await productRepository.GetProducts();

            SalesRepository salesRepository = new SalesRepository();
            List<Sale> sales = await salesRepository.GetSales();

            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            SaleProductRepository saleProductsRepository = new SaleProductRepository();
            List<SaleProduct> saleProducts = await saleProductsRepository.GetSaleProducts();

            List<SalesInfo> salesInfo = new List<SalesInfo>();

            foreach (Sale s in sales)
            {
                SalesInfo si = new SalesInfo();
                si.SaleID = s.SaleID;
                si.StoreID = s.StoreID;
                si.UserID = s.UserID;
                si.UserFullName = s.User.UserFullName;

                si.StoreName = s.Store.StoreName;
                si.Address = s.Store.Address;

                si.CreatedAt = s.CreatedAt;
                salesInfo.Add(si);
            }

            foreach (SalesInfo si in salesInfo)
            {
                foreach (SaleProduct sp in saleProducts)
                {
                    if (si.SaleID == sp.SaleID)
                    {
                        si.ProductID = sp.ProductID;
                        si.ProductName = sp.Product.ProductName;
                        si.ProductPrice = sp.Product.Price;
                        si.ProductSKU = sp.Product.SKU;
                        si.Quantity = sp.Quantity;
                        si.Total = sp.Quantity * sp.Product.Price;

                    }
                }
            }

            foreach (SalesInfo si in salesInfo)
            {
                foreach (Product p in products)
                {
                    if (si.ProductID == p.ProductID)
                    {
                        si.CategoryName = p.Category.CategoryName;
                    }
                }
            }

            foreach (SalesInfo si in salesInfo)
            {
                foreach (User u in users)
                {
                    if (si.UserID == u.UserID)
                    {
                        si.RoleName = u.Role.RoleName;
                    }
                }
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfd.FileName = "SalesInfo.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("SalesInfo");

                        // Заголовки
                        ws.Cells[1, 1].Value = "ID";
                        ws.Cells[1, 2].Value = "User Name";
                        ws.Cells[1, 3].Value = "User Role";
                        ws.Cells[1, 4].Value = "Product Name";
                        ws.Cells[1, 5].Value = "Product Category";
                        ws.Cells[1, 6].Value = "Product Count";
                        ws.Cells[1, 7].Value = "Product Price";
                        ws.Cells[1, 8].Value = "Product SKU";
                        ws.Cells[1, 9].Value = "Total Charge";
                        ws.Cells[1, 10].Value = "Store Name";
                        ws.Cells[1, 11].Value = "Store Address";
                        ws.Cells[1, 12].Value = "Date Of Sale";

                        for (int i = 0; i < salesInfo.Count; i++)
                        {
                            var si = salesInfo[i];
                            ws.Cells[i + 2, 1].Value = i + 1;
                            ws.Cells[i + 2, 2].Value = si.UserFullName;
                            ws.Cells[i + 2, 3].Value = si.RoleName;
                            ws.Cells[i + 2, 4].Value = si.ProductName;
                            ws.Cells[i + 2, 5].Value = si.CategoryName;
                            ws.Cells[i + 2, 6].Value = si.Quantity;
                            ws.Cells[i + 2, 7].Value = si.ProductPrice;
                            ws.Cells[i + 2, 8].Value = si.ProductSKU;
                            ws.Cells[i + 2, 9].Value = si.Total;
                            ws.Cells[i + 2, 10].Value = si.StoreName;
                            ws.Cells[i + 2, 11].Value = si.Address;
                            ws.Cells[i + 2, 12].Value = si.CreatedAt.ToString();
                        }

                        ws.Cells.AutoFitColumns();

                        // Зберігаємо в обраний файл
                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("File was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private async void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide
            dataGridView1.Visible = false;
            AddCategButton.Visible = false;
            button2.Visible = false;
            btnUpdCateg.Visible = false;

            btnStoreAdd.Visible = false;
            btnStoreDelete.Visible = false;
            btnStoreUpdate.Visible = false;
            showAllProducts.Visible = false;
            showAllSales.Visible = false;

            btnRoleAdd.Visible = false;
            btnRoleDelete.Visible = false;
            btnRoleUpdate.Visible = false;

            btnProductAdd.Visible = false;
            btnProductDelete.Visible = false;
            btnProductUpdate.Visible = false;

            btnUserAdd.Visible = false;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;

            btnAddOperation.Visible = false;
            btnDeleteOperation.Visible = false;

            //show
            btnExportCategoriesExcl.Visible = true;
            prodExpExc.Visible = true;
            storesExpExc.Visible = true;
            allSalesInfo.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            prodhtml.Visible = true;
            categhtml.Visible = true;
            storesexp.Visible = true;
            allsaleshtml.Visible = true;

            numberOfCateg.Visible = true;
            numberOfProd.Visible = true;
            numberOfStores.Visible = true;
            numberOfUsers.Visible = true;
            numberOfOps.Visible = true;


            ProductRepository prRepository = new ProductRepository();
            List<Product> products = await prRepository.GetProducts();

            CategoryRepository catRepository = new CategoryRepository();
            List<Category> categories = await catRepository.GetCategories();

            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            SaleProductRepository saleProductsRepository = new SaleProductRepository();
            List<SaleProduct> saleProducts = await saleProductsRepository.GetSaleProducts();

            StoreRepository storeRepository = new StoreRepository();
            List<Store> stores = await storeRepository.GetStores();

            numberOfCateg.Text = $"Number of Categories: {categories.Count()}";
            numberOfProd.Text = $"Number of Products: {products.Count()}";
            numberOfStores.Text = $"Number of Stores: {stores.Count()}";
            numberOfUsers.Text = $"Number of Users: {users.Count()}";
            numberOfOps.Text = $"Number of Operations: {saleProducts.Count()}";

        }

        private async void prodhtml_Click(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            List<Product> products = await repository.GetProducts();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "HTML files (*.html)|*.html";
                sfd.FileName = "Products.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.WriteLine("<!DOCTYPE html>");
                        writer.WriteLine("<html><head><meta charset=\"UTF-8\"><title>Products</title>");
                        writer.WriteLine("<style>table { border-collapse: collapse; width: 100%; }");
                        writer.WriteLine("th, td { border: 1px solid #aaa; padding: 8px; text-align: left; }");
                        writer.WriteLine("th { background-color: #f2f2f2; }</style></head><body>");
                        writer.WriteLine("<h2>Product List</h2>");
                        writer.WriteLine("<table>");
                        writer.WriteLine("<tr><td>ID</td><th>Name</th><th>Price</th><th>SKU</th><th>Category</th></tr>");
                        int i = 1;
                        foreach (var product in products)
                        {
                            writer.WriteLine($"<tr><td>{i++}</td><td>{product.ProductName}</td><td>{product.Price:F2}</td><td>{product.SKU}</td><td>{product.Category.CategoryName}</td></tr>");
                        }

                        writer.WriteLine("</table></body></html>");
                    }

                    MessageBox.Show("HTML-file was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void categexp_Click(object sender, EventArgs e)
        {
            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = await repository.GetCategories();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "HTML files (*.html)|*.html";
                sfd.FileName = "Categories.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.WriteLine("<!DOCTYPE html>");
                        writer.WriteLine("<html><head><meta charset=\"UTF-8\"><title>Categories</title>");
                        writer.WriteLine("<style>table { border-collapse: collapse; width: 100%; }");
                        writer.WriteLine("th, td { border: 1px solid #aaa; padding: 8px; text-align: left; }");
                        writer.WriteLine("th { background-color: #f2f2f2; }</style></head><body>");
                        writer.WriteLine("<h2>Categories List</h2>");
                        writer.WriteLine("<table>");
                        writer.WriteLine("<tr><td>ID</td><th>Name</th></tr>");
                        int i = 1;
                        foreach (var categ in categories)
                        {
                            writer.WriteLine($"<tr><td>{i++}</td><td>{categ.CategoryName}</td></tr>");
                        }

                        writer.WriteLine("</table></body></html>");
                    }

                    MessageBox.Show("HTML-file was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void storesexp_Click(object sender, EventArgs e)
        {
            StoreRepository storeRepository = new StoreRepository();
            List<Store> stores = await storeRepository.GetStores();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "HTML files (*.html)|*.html";
                sfd.FileName = "Stores.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.WriteLine("<!DOCTYPE html>");
                        writer.WriteLine("<html><head><meta charset=\"UTF-8\"><title>Stores</title>");
                        writer.WriteLine("<style>table { border-collapse: collapse; width: 100%; }");
                        writer.WriteLine("th, td { border: 1px solid #aaa; padding: 8px; text-align: left; }");
                        writer.WriteLine("th { background-color: #f2f2f2; }</style></head><body>");
                        writer.WriteLine("<h2>Stores List</h2>");
                        writer.WriteLine("<table>");
                        writer.WriteLine("<tr><td>ID</td><th>Store Name</th><th>Address</th><th>Created At</th></tr>");
                        int i = 1;
                        foreach (var s in stores)
                        {
                            writer.WriteLine($"<tr><td>{i++}</td><td>{s.StoreName}</td><td>{s.Address}</td><td>{s.CreatedAt}</td></tr>");
                        }

                        writer.WriteLine("</table></body></html>");
                    }

                    MessageBox.Show("HTML-file was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private async void button3_Click(object sender, EventArgs e)
        {
            StoreRepository storeRepository = new StoreRepository();
            List<Store> stores = await storeRepository.GetStores();

            ProductRepository productRepository = new ProductRepository();
            List<Product> products = await productRepository.GetProducts();

            SalesRepository salesRepository = new SalesRepository();
            List<Sale> sales = await salesRepository.GetSales();

            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            SaleProductRepository saleProductsRepository = new SaleProductRepository();
            List<SaleProduct> saleProducts = await saleProductsRepository.GetSaleProducts();

            List<SalesInfo> salesInfo = new List<SalesInfo>();

            foreach (Sale s in sales)
            {
                SalesInfo si = new SalesInfo();
                si.SaleID = s.SaleID;
                si.StoreID = s.StoreID;
                si.UserID = s.UserID;
                si.UserFullName = s.User.UserFullName;

                si.StoreName = s.Store.StoreName;
                si.Address = s.Store.Address;

                si.CreatedAt = s.CreatedAt;
                salesInfo.Add(si);
            }

            foreach (SalesInfo si in salesInfo)
            {
                foreach (SaleProduct sp in saleProducts)
                {
                    if (si.SaleID == sp.SaleID)
                    {
                        si.ProductID = sp.ProductID;
                        si.ProductName = sp.Product.ProductName;
                        si.ProductPrice = sp.Product.Price;
                        si.ProductSKU = sp.Product.SKU;
                        si.Quantity = sp.Quantity;
                        si.Total = sp.Quantity * sp.Product.Price;

                    }
                }
            }

            foreach (SalesInfo si in salesInfo)
            {
                foreach (Product p in products)
                {
                    if (si.ProductID == p.ProductID)
                    {
                        si.CategoryName = p.Category.CategoryName;
                    }
                }
            }

            foreach (SalesInfo si in salesInfo)
            {
                foreach (User u in users)
                {
                    if (si.UserID == u.UserID)
                    {
                        si.RoleName = u.Role.RoleName;
                    }
                }
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "HTML files (*.html)|*.html";
                sfd.FileName = "AllSalesInfo.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.WriteLine("<!DOCTYPE html>");
                        writer.WriteLine("<html><head><meta charset=\"UTF-8\"><title>All Sales Info</title>");
                        writer.WriteLine("<style>table { border-collapse: collapse; width: 100%; }");
                        writer.WriteLine("th, td { border: 1px solid #aaa; padding: 8px; text-align: left; }");
                        writer.WriteLine("th { background-color: #f2f2f2; }</style></head><body>");
                        writer.WriteLine("<h2>All Sales Info</h2>");
                        writer.WriteLine("<table>");
                        writer.WriteLine("<tr><td>ID</td><th>User Name</th><th>User Role</th><th>Product Name</th>" +
                            "<th>Product Category</th><th>Product Price</th>" +
                            "<th>Quantity</th><th>Product SKU</th><th>Total Charge</th><th>Store Name</th>" +
                            "<th>Store Address</th><th>Date Of Sale</th></tr>");
                        int i = 1;
                        foreach (var s in salesInfo)
                        {
                            writer.WriteLine($"<tr><td>{i++}</td><td>{s.UserFullName}</td>" +
                                $"<td>{s.RoleName}</td><td>{s.ProductName}</td>" +
                                $"<td>{s.CategoryName}</td><td>{s.ProductPrice:F2}</td>" +
                                $"<td>{s.Quantity}</td><td>{s.ProductSKU}</td>" +
                                $"<td>{s.Total:F2}</td><td>{s.StoreName}</td>" +
                                $"<td>{s.Address}</td><td>{s.CreatedAt.ToString()}</td></tr>");
                        }
                        writer.WriteLine("</table></body></html>");
                    }

                    MessageBox.Show("HTML-file was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
