using MyCart_ClientLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCart_ClientLayer.Models
{
    public class productRepo : Iproduct
    {
        

        public productRepo()
        {
            this.products = new List<Product>()
            {
              new Product() { productId = 1, productPrice = 10, ProductCategory = "grocery", ProductName = "ParleG"},
              new Product() { productId = 2, productPrice = 50, ProductCategory = "grocery", ProductName = "Sugar" },
              new Product() { productId = 3, productPrice = 60, ProductCategory = "grocery", ProductName = "Rice"  }
            };



        }
        List<Product> products;
    

       

        public IEnumerable<Product> viewProducts()
        {
            return products;
        }

        public Product GetProductById(int ID)
        {
            Product productbyid = products.Where((product) => product.productId == ID).FirstOrDefault();
            return productbyid;
        }
    }



}

