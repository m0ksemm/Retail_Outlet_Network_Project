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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RONApp
{
    public partial class OperationCreateEditForm : Form
    {
        public OperationCreateEditForm(List<Product> products, List<Sale> sales)
        {
            

            InitializeComponent();
            var prods = products.OrderBy(pr => pr.ProductName).ToList();
            foreach (Product p in products)
            {
                this.ProductNames.Items.Add(p.ProductName);
            }
            this.Text = "Add Operation";

            //TIME

            

            

            var sals = sales.OrderBy(pr => pr.CreatedAt).ToList();
            foreach (Sale s in sales) 
            {
                this.comboBox1.Items.Add(s.CreatedAt.ToString() + " | " + s.User.UserFullName + 
                    " | " + s.Store.StoreName + " | " + s.Store.Address  );
            }

            
        }

        private Guid prodsale_id = Guid.Parse("00000000-0000-0000-0000-000000000000");

        private async void button1_Click(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            List<Product> sps = await repository.GetProducts();

            Product? s = sps.FirstOrDefault(temp => temp.ProductName == ProductNames.SelectedItem.ToString());

            SalesRepository salesRepository = new SalesRepository();


            SaleProduct sp = new SaleProduct();
            //sp.SaleProductID = prodsale_id;
            sp.ProductID = s.ProductID;
            sp.Quantity = Convert.ToInt32(numericUpDown1.Value);
            sp.Price = double.Parse(textBox1.Text);

            ProductRepository prRepository = new ProductRepository();

            string[] opp = comboBox1.Text.Split(" | ");

            SalesRepository saleRepository = new SalesRepository();
            List<Sale> sales = await saleRepository.GetSales();

            Sale sale = sales.FirstOrDefault(s => s.CreatedAt.ToString() == opp[0] 
                        && s.User.UserFullName == opp[1] 
                        && s.Store.StoreName == opp[2] 
                        && s.Store.Address == opp[3]);

            sp.SaleID = sale.SaleID;

            SaleProductRepository saleProductRepository = new SaleProductRepository();

            await saleProductRepository.CreateSaleProduct(sp);


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
