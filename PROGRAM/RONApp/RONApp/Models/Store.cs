using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONApp.Models
{
    public class Store
    {
        public Guid StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
