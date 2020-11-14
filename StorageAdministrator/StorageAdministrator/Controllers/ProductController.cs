using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorageAdministrator.Services;

namespace StorageAdministrator.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        public IActionResult Product()
        {

            return View();
        }
    }
}
