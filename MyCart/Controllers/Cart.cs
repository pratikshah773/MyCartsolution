using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCart_ClientLayer.Models;
using MyCart_ClientLayer.Data;

namespace MyCart_ClientLayer.Controllers
{
    public class CartController : Controller
    {

        private Datacontext _datacontext { get; set; }


        public CartController(Datacontext datacontext)
        {
            _datacontext= datacontext ;

        }
        
        public ActionResult AddtoCart()
        {


            
            return Content("hi from cart");

        }

    }
}