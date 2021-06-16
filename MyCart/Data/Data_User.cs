using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart_ClientLayer.Data
{
    public class Data_User
    {
        [Key]
        public int UserId { get; set; }

        
        public String UserName { get; set; }


        
        public string Password { get; set; }

      

        [ForeignKey("CartID")]
        public Data_Cart CartId { get; set; }



    }
}
