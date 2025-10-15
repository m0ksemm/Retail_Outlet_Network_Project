using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONApp.Models
{
    public class SalesInfo
    {
        public Guid SaleID { get; set; }
        public Guid ProductID { get; set; }
        public Guid StoreID { get; set; }
        public Guid UserID { get; set; }
        public string? UserFullName { get; set; }
        public string? RoleName { get; set; }
        public string? ProductName { get; set; }
        public string? CategoryName { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }
        public string? ProductSKU { get; set; }
        public double? Total { get; set; }
        public string? StoreName { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
