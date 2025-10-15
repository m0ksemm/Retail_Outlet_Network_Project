using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace RONApp.Models
{
    public class Sale
    {
        public Guid SaleID { get; set; }
        public Guid StoreID { get; set; }
        public Guid UserID { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public Store? Store { get; set; }
        public User? User { get; set; }
    }
}
