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
    public partial class CategoryCreateEditForm : Form
    {
        public CategoryCreateEditForm()
        {
            this.Text = "Add Category";
            InitializeComponent();
        }



        public void EditCategory(Category category)
        {
            this.Text = "Edit Category";
            label1.Text = "Edit Category";
            textBox1.Text = category.CategoryName;
            categ_id = category.CategoryID;
        }

        private Guid categ_id = Guid.Parse("00000000-0000-0000-0000-000000000000") ;

        private async void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryID = categ_id;
            category.CategoryName = textBox1.Text;

            CategoryRepository repository = new CategoryRepository();

            if (category.CategoryID == Guid.Parse("00000000-0000-0000-0000-000000000000")) 
            {
                await repository.CreateCategory(category);
            }
            else
            {
                await repository.UpdateCategory(category);
            }
            

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
