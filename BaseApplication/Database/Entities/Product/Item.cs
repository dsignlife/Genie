using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities.Product
{
    public class Item
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime LastestEventTime { get; set; }
        public DateTime FirstEventTime { get; set; }
    }
}
