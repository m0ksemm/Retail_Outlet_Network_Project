using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RON.WebAPI.Models
{
    public class SaleProduct
    {
        [Key]
        public Guid SaleProductID { get; set; }
        public Guid SaleID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        [ForeignKey("SaleID")]
        public Sale? Sale { get; set; }
        [ForeignKey("ProductID")]
        public Product? Product { get; set; }
    }
}

