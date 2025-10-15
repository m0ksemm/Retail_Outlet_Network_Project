using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Packaging.Signing;

namespace RON.WebAPI.Models
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public Guid CategoryID { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("CategoryID")]
        public Category? Category { get; set; }
    }
}
