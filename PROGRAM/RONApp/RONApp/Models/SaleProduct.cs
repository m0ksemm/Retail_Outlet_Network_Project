using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONApp.Models
{
    public class SaleProduct
    {
        public Guid SaleProductID { get; set; }
        public Guid SaleID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Sale? Sale { get; set; }
        public Product? Product { get; set; }
    }
}
