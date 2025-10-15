using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace RON.WebAPI.Models
{
    public class Role
    {
        [Key]
        public Guid RoleID { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
