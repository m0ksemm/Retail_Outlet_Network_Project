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
    public partial class UserCreateEditForm : Form
    {
        public UserCreateEditForm(List<Role> roles)
        {
            InitializeComponent();
            foreach (Role role in roles)
            {
                this.Roles.Items.Add(role.RoleName);
            }
            this.Text = "Add User";
        }

        private Guid user_id = Guid.Parse("00000000-0000-0000-0000-000000000000");

        public void EditUser(User user)
        {
            this.Text = "Edit User";
            label1.Text = "Edit User";
            textBox1.Text = user.UserName;
            textBox2.Text = user.UserFullName;
            textBox3.Text = user.PasswordHash;
            Roles.SelectedItem = user.Role.RoleName;

            user_id = user.UserID;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            RoleRepository rolesRepository = new RoleRepository();
            List<Role> roles = await rolesRepository.GetRoles();

            Role? role = roles.FirstOrDefault(temp => temp.RoleName == Roles.SelectedItem.ToString());

            User user = new User();
            user.UserID =user_id;
            user.UserName = textBox1.Text;
            user.UserFullName = textBox2.Text;
            user.PasswordHash = textBox3.Text;
            user.RoleID = role.RoleID;


            UsersRepository usersRepository = new UsersRepository();

            if (user.UserID == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                await usersRepository.CreateUser(user);
            }
            else
            {
                await usersRepository.UpdateUser(user);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
