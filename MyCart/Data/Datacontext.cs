using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart_ClientLayer.Data
{
    public class Datacontext : DbContext
    {


        public Datacontext(DbContextOptions<Datacontext> options) : base(options) { }
        
        public DbSet<Data_Cart> data_Carts { get; set; }
        public DbSet<Data_Product> data_Products { get; set; }
        public DbSet<Data_User> data_Users { get; set; }
    
    }




    


}
