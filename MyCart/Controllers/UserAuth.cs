using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCart_ClientLayer.Data;
using MyCart_ClientLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace MyCart_ClientLayer.Controllers
{
    public class UserAuth : Controller
    {
        private IUserRepository _userRepository;
        private  Datacontext _datacontext;

        public UserAuth(IUserRepository  userRepository , Datacontext datacontext )
        {
            _userRepository = userRepository;
            _datacontext = datacontext;
        }
        [HttpGet]
        public IActionResult Login()
        {


            string strUserName = HttpContext.Session.GetString("User");


            if (strUserName != null)
            { return Content("your session is active"); }
            else

                return View();
        }

        [HttpPost]
        public IActionResult Login( User user)
            
            

        {


            if ((user.UserName != null & user.Password != null) & (user.UserName != " " & user.Password != " "))
            {

                var UserFound = _datacontext.data_Users.FirstOrDefault(x => x.UserName == user.UserName);

                var passmatch = UserFound.Password;

                if (UserFound != null & passmatch == user.Password)
                {
                    HttpContext.Session.SetString("User", user.UserName);
                    return RedirectToAction("Index", "Home");
                }

                else { return Content("INVALID User"); }

                
               
               

            }
            else
                
                {
                return Content("invalid inputs");
                    
                }
          

        }

        [HttpGet]
        public IActionResult Register()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Register(User user)
        {

            Data_User datauser = new Data_User();
            datauser.UserId = user.UserId;
            datauser.UserName = user.UserName;
            datauser.Password = user.Password;


            _datacontext.data_Users.Add(datauser);
            _datacontext.SaveChanges();

            return Content("Registration Successful , Please Login");
        }
    }
}
