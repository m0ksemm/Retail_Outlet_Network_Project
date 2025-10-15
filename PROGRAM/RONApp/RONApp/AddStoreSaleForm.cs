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
    public partial class AddStoreSaleForm : Form
    {
        public AddStoreSaleForm(Store store, List<User> users)
        {
            InitializeComponent();

            StoreName.Text = store.StoreName + ", " + store.Address;
            this.Text = "Add Sale";
            label1.Text = "Create new Sale";

            store_id = store.StoreID;


            _users = new List<User>();
            var usrs = users.OrderBy(us => us.UserFullName).ToList();
            foreach (User u in usrs)
            {
                comboBox1.Items.Add(u.UserFullName);
                _users.Add(u);
            }
        }

        Guid _sale_id = Guid.Parse("00000000-0000-0000-0000-000000000000");
        Guid store_id;
        List<User> _users;

        public async void EditStoreSale(Sale sale)
        {
            this.Text = "Edit Sale";
            label1.Text = "Edit Sale";
            this._sale_id = sale.SaleID;
            textBox1.Text = sale.Total.ToString();

            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            //products.FirstOrDefault(p => p.ProductID == inv.ProductID).ProductName

            comboBox1.SelectedItem = users.FirstOrDefault(p => p.UserID == sale.UserID).UserFullName;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.SaleID = _sale_id;
            sale.StoreID = store_id;
            sale.UserID = _users.FirstOrDefault(temp => temp.UserFullName == comboBox1.SelectedItem.ToString()).UserID;
            sale.Total = double.Parse(textBox1.Text);
            sale.CreatedAt = DateTime.UtcNow;

            SalesRepository salesRepository = new SalesRepository();

            if (sale.SaleID == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                await salesRepository.CreateSale(sale);
            }
            else
            {
                await salesRepository.UpdateSale(sale);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
