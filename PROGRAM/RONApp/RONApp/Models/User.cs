using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONApp.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string UserFullName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public Guid RoleID { get; set; }
        public Role? Role { get; set; }
    }
}
