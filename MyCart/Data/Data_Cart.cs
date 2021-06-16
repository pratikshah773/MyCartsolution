using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart_ClientLayer.Data
{
    public class Data_Cart
    {
      
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

       
        public Data_User User { get; set; }


        
    }
}
