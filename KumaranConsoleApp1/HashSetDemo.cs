using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System;

namespace KumaranConsoleApp1
{
    internal class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string> {
                "Robin",
                "Joyson",
                "Kannan"
            };
            HashSet<string> names1 = new HashSet<string> {
                "Sanjesh",
                "Akash",
            };
            names.UnionWith(names1);//This method combines the elements, present
                                    //in both the collections into the collection
                                    //on which it is called
            names.IntersectWith(names1);//This method combines the elements that are common to both the collections.
            names1.ExceptWith(names);//This method removes all the elements that are
                                     //present in the other collections from the
                                     //collection on which it is called.
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
