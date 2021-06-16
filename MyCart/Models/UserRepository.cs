using Microsoft.AspNetCore.Mvc;
using MyCart_ClientLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCart_ClientLayer.Models
{

    public class UserRepository : IUserRepository
    {
        private readonly Datacontext datacontext;
      
        public UserRepository( Datacontext _Datacontext )
        {
            datacontext = _Datacontext;
        }
        

        
        public User Login(User user)
        {
            
            
            
            return user;
           


        }

        public User Register(User user)
        {
            throw new NotImplementedException();
        }
        //private User _pratik;

        //public UserRepository()
        //{
        //    User Pratik = new User() { UserId = 1, UserName = "Admin", Password = "Admin" };
        //    _pratik = Pratik;

        //}


        //public User getUser()
        //{
        //    return _pratik;
        //}




    }
}
