using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RON.WebAPI.Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        [Required]
        public string UserFullName { get; set; }
        [Required]
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public Guid RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Role? Role { get; set; }
    }
}
