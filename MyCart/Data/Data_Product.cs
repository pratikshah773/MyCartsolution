using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCart_ClientLayer.Data
{
    public class Data_Product
    {
            [Key]
            public int productId { get; set; }

            public string ProductName { get; set; }

            public int productPrice { get; set; }

            public string ProductCategory { get; set; }

            public string ProductImagePath { get; set; }

            public int ProductQuantity { get; set; }

        




    }
}
