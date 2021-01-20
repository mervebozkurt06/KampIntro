using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation -> içindeki özellikleri tek tek yazmamak için Product product
        public void Add(Product product) //string türünde ad (string ad)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi.");
        }

        

    }
}
