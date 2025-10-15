using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RONApp.Models;
using RONApp.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RONApp
{
    public partial class StoreProductCreateEditForm : Form
    {
        public StoreProductCreateEditForm(Store store, List<Product> products)
        {
            InitializeComponent();
            StoreName.Text = store.StoreName + ", " + store.Address;
            this.Text = "Add Product";

            store_id = store.StoreID;

            _products = new List<Product>();
            var prod = products.OrderBy(pr => pr.ProductName).ToList();
            foreach (Product pr in prod)
            {
                comboBox1.Items.Add(pr.ProductName);
                _products.Add(pr);
            }
        }


        Guid _inventory_id = Guid.Parse("00000000-0000-0000-0000-000000000000");
        Guid store_id;

        List<Product> _products;

        public async void EditStoreProduct(Inventory inv)
        {
            this.Text = "Edit Product";
            label1.Text = "Edit Product";
            this._inventory_id = inv.InventoryID;
            numericUpDown1.Value = inv.Quantity;

            ProductRepository productsRepository = new ProductRepository();
            List<Product> products = await productsRepository.GetProducts();

            //products.FirstOrDefault(p => p.ProductID == inv.ProductID).ProductName

            comboBox1.SelectedItem = products.FirstOrDefault(p => p.ProductID == inv.ProductID).ProductName;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            //Guid guid = _products.FirstOrDefault(temp => temp.ProductName == comboBox1.SelectedItem.ToString()).ProductID;
            Inventory inventory = new Inventory();
            inventory.InventoryID = _inventory_id;
            inventory.StoreID = store_id;
            inventory.ProductID = _products.FirstOrDefault(temp => temp.ProductName == comboBox1.SelectedItem.ToString()).ProductID;
            inventory.Quantity = Convert.ToInt32(numericUpDown1.Value);
             
            InventoryRepository repository = new InventoryRepository();

            if (inventory.InventoryID == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                await repository.CreateInventory(inventory);
            }
            else
            {
                await repository.UpdateInventory(inventory);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
