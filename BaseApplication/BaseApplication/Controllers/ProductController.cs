using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Entities.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Product;
using System.Reflection;


namespace BaseApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductRepository productRepository, ILogger<ProductController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult GetAllItems()
        {
            try
            {
                return Ok(_productRepository.GetAllItems());

            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to {MethodBase.GetCurrentMethod().Name}: {ex}");
                return BadRequest($"Failed to {MethodBase.GetCurrentMethod().Name}");

            }

        }
    }
}
