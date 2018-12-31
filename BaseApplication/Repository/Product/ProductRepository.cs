using Database.Entities;
using Database.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.Product
{
    class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public List<Item> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public List<Item> GetItemsByCategory(string category)
        {
            return _context.Items.Where(cat => cat.Category == category).ToList();
        }
    }
}
