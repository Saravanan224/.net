using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class OperatorOverloading
    {
        class Product
        {
            string CarName;
            int CarPrice;
            int NoCars;

            public Product(string cname, int cprice, int nocars)
            {
                CarName = cname;
                CarPrice= cprice;
                NoCars= nocars;
            }

            public void displayCarDetails()
            {
                Console.WriteLine("Car Name : {0}", CarName);
                Console.WriteLine("Car Price : {0}", CarPrice);
                Console.WriteLine("Number of Cars  : {0}", NoCars);
            }

            public static Product operator +(Product ca, Product cb)
            {
                Product Px = new Product("", 0, 0);
                Px.CarName = ca.CarName+ "," + cb.CarName;
                Px.CarPrice = ca.CarPrice + cb.CarPrice;
                Px.NoCars = ca.NoCars + cb.NoCars;
                return Px;
            }
        }
        static void Main(string[] args)
        {
            Product p1 = new Product("BMW I5", 4500000, 1);
            Product p2 = new Product("Bmw I6", 3000000, 1);
            Product p3;
            p3 = p1 + p2;
            p1.displayCarDetails();
            p2.displayCarDetails();
            p3.displayCarDetails();
            Console.ReadKey();
        }

    }
}
