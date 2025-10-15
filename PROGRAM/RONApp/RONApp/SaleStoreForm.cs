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
    public partial class SaleStoreForm : Form
    {
        public SaleStoreForm(Store store)
        {
            InitializeComponent();

            _store = new Store();
            _store.StoreID = store.StoreID;
            _store.StoreName = store.StoreName;
            _store.Address = store.Address;
            _store.CreatedAt = store.CreatedAt;


            dataGridView1.RowTemplate.Height = 30;
            labelShopName.Text = store.StoreName + ", " + store.Address;
            ReadShowSales();
        }

        private Store _store;

        async Task ReadShowSales()
        {
            SalesRepository salesRepository = new SalesRepository();
            List<Sale> sales = await salesRepository.GetSales();

            DataTable table = new DataTable();
            table.Columns.Add("Sale ID");
            table.Columns.Add("Made by");
            table.Columns.Add("Total");
            table.Columns.Add("Created At");

            int k = 0;
            for (int i = 0; i < sales.Count; i++)
            {
                if (_store.StoreID == sales[i].StoreID)
                {
                    var row = table.NewRow();
                    row["Sale ID"] = 1 + k++;
                    row["Made by"] = sales[i].User.UserFullName;
                    row["Total"] = sales[i].Total;
                    row["Created At"] = sales[i].CreatedAt;

                    table.Rows.Add(row);
                }
            }

            dataGridView1.DataSource = table;
        }

        private async void addSaleStoreBtn_Click(object sender, EventArgs e)
        {
            UsersRepository usersRepository = new UsersRepository();
            List<User> users = await usersRepository.GetUsers();

            AddStoreSaleForm form = new AddStoreSaleForm(_store, users);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadShowSales();
            }
        }

        private async void deleteSaleStoreBtn_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            SalesRepository repository = new SalesRepository();
            List<Sale> allSales = await repository.GetSales();

            List<Sale> sl = new List<Sale>();
            foreach (Sale s in allSales)
            {
                if (s.StoreID == _store.StoreID)
                {
                    sl.Add(s);
                }
            }

            DialogResult dialogResult =
                MessageBox.Show("Are you sure that you want to delete this product?",
                "Product Store", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            await repository.DeleteSale(sl[client_id - 1].SaleID);
            await ReadShowSales();
        }

        private async void updateSaleStoreBtn_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int client_id = int.Parse(val);
            SalesRepository repository = new SalesRepository();
            List<Sale> sales = await repository.GetSales();
            List<Sale> sls = new List<Sale>();
            foreach (Sale sl in sales)
            {
                if (sl.StoreID == _store.StoreID)
                {
                    sls.Add(sl);
                }
            }

            Sale s = new Sale();
            s.SaleID = sls[client_id - 1].SaleID;
            s.StoreID = sls[client_id - 1].StoreID;
            s.UserID = sls[client_id - 1].UserID;
            s.Total = sls[client_id - 1].Total;
            s.CreatedAt = sls[client_id - 1].CreatedAt;

            UsersRepository productsRepository = new UsersRepository();
            List<User> users = await productsRepository.GetUsers();

            AddStoreSaleForm frm = new AddStoreSaleForm(_store, users);
            frm.EditStoreSale(s);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await ReadShowSales();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
