using System.ComponentModel.DataAnnotations;

namespace RON.WebAPI.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; }    
        public string CategoryName { get; set; }
    }
}
