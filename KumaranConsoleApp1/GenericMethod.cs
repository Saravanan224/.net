using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class GenericMethod
    {
        class GetAndSort<T>
        {
            public void SortAndDisplay(List<T> list)
            {
                list.Sort();
                foreach (T item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Trainees Name..........");
            List<string> Trainees = new List<string>()
                                   {"Sri","Robin","Joyson","Kannan"};

            //Consuming GetAndSort for string type.
            GetAndSort<string> gs1 = new GetAndSort<string>();
            gs1.SortAndDisplay(Trainees);

            //Consuming GetAndSort for integer type.
            Console.WriteLine("Trainee Commutable Language");
            List<String> language = new List<String>() {"C#","Java",".net","Sql"};
            GetAndSort<string> gs2 = new GetAndSort<string>();
            gs2.SortAndDisplay(language);

            Console.ReadKey();

        }
    }
}
