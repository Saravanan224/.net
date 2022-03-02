using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class SquareOfGivenValues
    {
        static void Main()
        {
            int[] a = new int[10];

            Console.WriteLine("Enter 5 values");
            for (int i = 0; i < 10; i = i + 2) 
            {
                a[i] = int.Parse(Console.ReadLine());       
                a[i + 1] = a[i] * a[i];                     
            }

            Console.WriteLine("Value and Square");
            for (int i = 0; i < 10; i = i + 2)            
            {
                Console.Write(a[i] + "\t" + a[i + 1]);    
                Console.WriteLine();
            }

            Console.ReadKey(); //getch();
        }
    }
}
