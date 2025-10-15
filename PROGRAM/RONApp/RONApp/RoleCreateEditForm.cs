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
    public partial class RoleCreateEditForm : Form
    {
        public RoleCreateEditForm()
        {
            InitializeComponent();
            this.Text = "Add Role";

        }

        private Guid role_id = Guid.Parse("00000000-0000-0000-0000-000000000000");


        public void EditRole(Role role)
        {
            this.Text = "Edit Role";
            label1.Text = "Edit Role";
            textBox1.Text = role.RoleName;
            role_id = role.RoleID;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.RoleID = role_id;
            role.RoleName = textBox1.Text;

            RoleRepository repository = new RoleRepository();

            if (role.RoleID == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                await repository.CreateRole(role);
            }
            else
            {
                await repository.UpdateRole(role);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }




    }
}
