using System;

namespace Week2HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.Price = 7.890f;
            product1.Quantity = 30;

            Product product2 = new Product();
            product2.ProductName = "Desktop Computer";
            product2.Price = 5.69f;
            product2.Quantity = 30;

            Product[] products = new Product[] { product1, product2 };


            int i = 0;
            while (true)
            {
                Console.WriteLine(products[i].ProductName + " " + products[i].Price + " " + products[i].Quantity);
                i++;
                if(i==products.Length)
                {
                    break;
                }
                
            }

            for (i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " " + products[i].Price + " " + products[i].Quantity);
            }

            foreach (var x in products)
            {
                Console.WriteLine(x.ProductName + " " + x.Price + " " + x.Quantity);
            }

            
            
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

    }
}
