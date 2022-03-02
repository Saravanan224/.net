using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class AutoImpProps
    {
        class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
        }
        static void Main()
        {
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Keyboard",
                Price = 450
            };
            Console.WriteLine(product.ProductId);
            Console.WriteLine(product.ProductName);
            Console.WriteLine(product.Price);
        }

    }
}
