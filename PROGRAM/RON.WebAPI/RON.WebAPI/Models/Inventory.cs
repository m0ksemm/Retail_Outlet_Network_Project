using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace RON.WebAPI.Models
{
    public class Inventory
    {
        [Key]
        public Guid InventoryID { get; set; }
        public Guid StoreID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("StoreID")]
        public Store? Store { get; set; }
        [ForeignKey("ProductID")]
        public Product? Product { get; set; }
    }
}
