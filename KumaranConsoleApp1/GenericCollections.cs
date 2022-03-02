using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class GenericCollections
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Trainees Name.......... ");
            List<string> Trainees = new List<string>();
            Trainees.Add("Robin");
            Trainees.Add("Joyson");
            Trainees.Add("Sri");
            Trainees.Add("Kannan");

            foreach (string item in Trainees)
            {
                Console.WriteLine(item);
            }

            Trainees.Sort();
            Console.WriteLine("\nAfter sorting Trainee Names......");
            foreach (string item in Trainees)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

