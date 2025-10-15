using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RON.WebAPI.Models
{
    public class Sale
    {
        [Key]
        public Guid SaleID { get; set; }
        public Guid StoreID { get; set; }
        public Guid UserID { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("StoreID")]
        public Store? Store { get; set; }
        [ForeignKey("UserID")]
        public User? User { get; set; }
    }
}
