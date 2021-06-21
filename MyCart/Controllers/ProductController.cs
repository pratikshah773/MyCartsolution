using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCart_ClientLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart_ClientLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly Iproduct _prod;

        public ProductController( Iproduct  prod)
        {
            _prod = prod;
        }
        // GET: product
        public ActionResult Index()
        {
            IEnumerable<Product> listofProducts  = _prod.viewProducts();

            return View("ProductCards", listofProducts);
        }

        // GET: product/Details/5
        public ActionResult Details(int id)
        {
           Product productById= _prod.GetProductById(id);
            return View(productById);
        }

        public IActionResult ProductCards()
        {
            IEnumerable<Product> listofProducts = _prod.viewProducts();

            return View(listofProducts);

            
        
        }
    }
}
