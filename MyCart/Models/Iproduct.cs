using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyCart_ClientLayer.Models
{
    public interface Iproduct
    {
        public IEnumerable<Product> viewProducts ();

        public Product GetProductById(int ID);
         


      


    }
}
