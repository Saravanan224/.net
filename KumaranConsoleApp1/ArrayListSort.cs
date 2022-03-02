using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class ArrayListSort
    {
        static void Main(string[] args)
        {
            ArrayList personList = new ArrayList();
            personList.Add("Rakul");
            personList.Add("Kannan");
            personList.Add("Sri");
            personList.Add("Joyson");
            personList.Add("Robin");
            Console.WriteLine("Original List");
            PrintValues(personList);
            //sort the list  
            personList.Sort();
            Console.WriteLine("Sorted List");
            PrintValues(personList);
            Console.Read();

        }
        private static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.WriteLine($"Name is: {obj}");
            }
        }
    }
}
