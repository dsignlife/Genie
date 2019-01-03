using Database.Entities;
using Database.Entities.Product;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Repository.Product
{
    class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context, ILogger<ProductRepository> logger)
        {
            _logger = logger;
            _context = context;
        }

        public List<Item> GetAllItems()
        {
            try
            {
                _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} was called");
                return _context.Items.ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to {MethodBase.GetCurrentMethod().Name}: {ex}");
                return null;

            }
        }

        public List<Item> GetItemsByCategory(string category)
        {
            try
            {
                _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} was called");
                return _context.Items.Where(cat => cat.Category == category).ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to {MethodBase.GetCurrentMethod().Name}: {ex}");
                return null;

            }
        }
    }
}
