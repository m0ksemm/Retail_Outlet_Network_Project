using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RONApp.Models;
using RONApp.Repositories;

namespace RONApp
{
    public partial class InventoryStoreForm : Form
    {
        public InventoryStoreForm(Store store)
        {
            InitializeComponent();

            _store = new Store();
            _store.StoreID = store.StoreID;
            _store.StoreName = store.StoreName;
            _store.Address = store.Address;
            _store.CreatedAt = store.CreatedAt;


            dataGridView1.RowTemplate.Height = 30;
            labelShopName.Text = store.StoreName + ", " + store.Address;
            ReadShowInventory();
        }

        private Store _store;

        async Task ReadShowInventory()
        {
            InventoryRepository inventoryRepository = new InventoryRepository();

            List<Inventory> inventory = await inventoryRepository.GetAllInventory();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Product Name");
            table.Columns.Add("Product Category");
            table.Columns.Add("Product Price");
            table.Columns.Add("Quantity");

            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = await categoryRepository.GetCategories();
            int k = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (_store.StoreID == inventory[i].StoreID)
                {
                    var row = table.NewRow();
                    row["ID"] = 1 + k++;
                    row["Product Name"] = inventory[i].Product.ProductName;
                    row["Product Category"] = categories.FirstOrDefault(temp => temp.CategoryID == inventory[i].Product.CategoryID).CategoryName;
                    row["Product Price"] = inventory[i].Product.Price;
                    row["Quantity"] = inventory[i].Quantity;

                    table.Rows.Add(row);
                }
            }

            dataGridView1.DataSource = table;


            
        }

        private async void addProductStoreBtn_Click(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            List<Product> products = await repository.GetProducts();

            StoreProductCreateEditForm form = new StoreProductCreateEditForm(_store, products);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowInventory();
            }
        }

        private async void deleteProductStoreBtn_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            InventoryRepository repository = new InventoryRepository();
            List<Inventory> allInventory = await repository.GetAllInventory();

            List<Inventory> invents = new List<Inventory>();
            foreach (Inventory inv in allInventory)
            {
                if (inv.StoreID == _store.StoreID)
                {
                    invents.Add(inv);
                }
            }

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this product?",
                "Product Store", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteInventory(invents[client_id - 1].InventoryID);
            await ReadShowInventory();
        }

        private async void updateProductStoreBtn_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            InventoryRepository repository = new InventoryRepository();
            List<Inventory> inventors = await repository.GetAllInventory();
            List<Inventory> invents = new List<Inventory>();
            foreach (Inventory inv in inventors)
            {
                if (inv.StoreID == _store.StoreID)
                {
                    invents.Add(inv);
                }
            }

            Inventory i = new Inventory();
            i.InventoryID = invents[client_id - 1].InventoryID;
            i.StoreID = invents[client_id - 1].StoreID;
            i.ProductID = invents[client_id - 1].ProductID;
            i.Quantity = invents[client_id - 1].Quantity;

            ProductRepository productsRepository = new ProductRepository();
            List<Product> products = await productsRepository.GetProducts();

            StoreProductCreateEditForm frm = new StoreProductCreateEditForm(_store, products);
            frm.EditStoreProduct(i);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowInventory();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
