using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONApp.Models
{
    public class Inventory
    {
        public Guid InventoryID { get; set; }
        public Guid StoreID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public Store? Store { get; set; }
        public Product? Product { get; set; }
    }
}
