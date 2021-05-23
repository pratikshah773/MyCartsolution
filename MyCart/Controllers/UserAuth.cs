using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart_ClientLayer.Controllers
{
    public class UserAuth : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Index(string Email , String Password)
        {
            ViewBag.Email = Email;

            return View("Welcome"+ViewBag.Email.toString()+Password.ToString());
        }


        public IActionResult Register()
        {


            return View();
        }
    }
}
