using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Product;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseApplication.Controllers
{
    public class AppController : Controller
    {
        private readonly IProductRepository _productRepository;

        public AppController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            var results = _productRepository.GetAllItems();

            return View(results);
        }
    }
}
