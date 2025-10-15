using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RON.WebAPI.Models
{
    public class Store
    {
        [Key]
        public Guid StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
