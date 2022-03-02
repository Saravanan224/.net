using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class MethodHidingOrShadowing
    {
        public class Person
        {
            public void Print()
            {
                Console.WriteLine("I am Person Method");
            }
        }

        class Employee : Person
        {
            public new void Print() //Add new keyword to skip the warning
            {
                Console.WriteLine("I am Employee method");
            }
        }

        class Manager : Employee
        {
            public new void Print() //Add new keyword to skip the warning
            {
                Console.WriteLine("I am Manager method");
            }
        }

        static void Main(string[] args)
        {
            Person p;

            p = new Person();
            p.Print();  //I am base

            p = new Employee();
            p.Print();  //I am base

            p = new Manager();
            p.Print(); //I am base

            Console.ReadKey();
        }
    }
}
