using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities.Product
{
    public class OrderItem
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Item Item { get; set; }
        public Order Order { get; set; }
    }
}
