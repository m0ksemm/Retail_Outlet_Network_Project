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
    public partial class StoresCreateEditForm : Form
    {
        public StoresCreateEditForm()
        {
            this.Text = "Add Store";
            InitializeComponent();
        }

        public void EditStore(Store store)
        {
            this.Text = "Edit Store";
            label1.Text = "Edit Store";
            textBox1.Text = store.StoreName;
            textBox2.Text = store.Address;

            store_id = store.StoreID;
        }

        private Guid store_id = Guid.Parse("00000000-0000-0000-0000-000000000000");


        private async void button1_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.StoreID = store_id;
            store.StoreName = textBox1.Text;
            store.Address = textBox2.Text;
            store.CreatedAt = DateTime.UtcNow;

            StoreRepository repository = new StoreRepository();

            if (store.StoreID == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                await repository.CreateStore(store);
            }
            else
            {
                await repository.UpdateStore(store);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
