using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart.Controllers
{
    public class Aboutus : Controller
    {
        public IActionResult Index()
        {
            return View ();
        }
    }
}
