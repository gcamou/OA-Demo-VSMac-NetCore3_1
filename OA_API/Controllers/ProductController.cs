using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OA_API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;

        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        [Route("products")]
        public IEnumerable<Product> GetProducts()
        {
            var products = _productRepo.GetAll();
            return products;
        }
    }
}
