using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class GenericCollectionsDemo
    {
        static void Main()
        {
            List<int> marks = new List<int>();
            marks.Add(35);
            marks.Add(46);
            marks.Add(68);
            marks.Add(78);
            marks.Add(88);

            Console.WriteLine("For each loop on list<int> type");
            foreach (int x in marks)
            {
                //going to something
                Console.WriteLine(x);
            }

            List<string> names = new List<string>();
            names.Add("Saran");
            names.Add("Sri");
            names.Add("Kavin");

            Console.WriteLine("For each loop on list<string> type");
            foreach (string x in names)
            {
                //going to something
                Console.WriteLine(x);
            }


            int[] marks2 = new int[10];
            marks2[0] = 90;
            marks2[1] = 85;
            marks2[2] = 96;
            marks2[3] = 56;
            marks2[4] = 46;

            Console.WriteLine("For each loop on array type");
            foreach (int x in marks2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("For loop on array type");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(marks2[i]);
            }

            Console.ReadKey();
        }
    }
}
