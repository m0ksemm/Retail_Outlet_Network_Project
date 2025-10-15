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
    public partial class ProductCreateEditForm : Form
    {
        public ProductCreateEditForm(List<Category> categories)
        {
            InitializeComponent();
            var categ = categories.OrderBy(category => category.CategoryName).ToList();
            foreach (Category category in categories)
            {
                this.CategoryNames.Items.Add(category.CategoryName);
            }
            this.Text = "Add Product";

        }
        private Guid prod_id = Guid.Parse("00000000-0000-0000-0000-000000000000");

        public void EditProduct(Product product)
        {
            this.Text = "Edit Product";
            label5.Text = "Edit Product";
            textBox1.Text = product.ProductName;
            CategoryNames.SelectedItem = product.Category.CategoryName;
            textBox3.Text = product.Price.ToString();
            textBox4.Text = product.SKU;

            prod_id = product.ProductID;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = await repository.GetCategories();

            //string s = CategoryNames.SelectedItem.ToString();

            Category? c = categories.FirstOrDefault(temp => temp.CategoryName == CategoryNames.SelectedItem.ToString());

            Product product = new Product();
            product.ProductID = prod_id;
            product.ProductName = textBox1.Text;
            product.CategoryID = c.CategoryID;
            product.Price = double.Parse(textBox3.Text);
            product.SKU = textBox4.Text;
            product.CreatedAt = DateTime.UtcNow;

            ProductRepository prRepository = new ProductRepository();

            if (product.ProductID == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                await prRepository.CreateProduct(product);
            }
            else
            {
                await prRepository.UpdateProduct(product);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
