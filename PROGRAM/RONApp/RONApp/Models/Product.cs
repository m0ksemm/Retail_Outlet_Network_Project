using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONApp.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public Guid CategoryID { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public DateTime CreatedAt { get; set; }
        public Category? Category { get; set; }
    }
}
