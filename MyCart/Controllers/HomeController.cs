using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {

           
            
            return View();
            

            
        }

        public ActionResult Privacy()
        {
            return Content("privacy page view");
        }

        
    }
}
