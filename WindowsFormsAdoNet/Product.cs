using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAdoNet
{
     public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public decimal product_price { get; set; }
        public int product_stock { get; set; }
    }
}
