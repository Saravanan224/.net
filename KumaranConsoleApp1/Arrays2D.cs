using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    internal class Arrays2D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students?");
            int studentsCount = int.Parse(Console.ReadLine());

            int[,] Marks = new int[studentsCount, 2];
            Console.WriteLine($"Enter marks of {studentsCount} Students");

            for (int student = 0; student < studentsCount; student++)
            {
                Console.WriteLine($"Enter internal and external marks of                                                 student {student + 1}");
                for (int sub = 0; sub < 2; sub++)
                {
                    Marks[student, sub] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"{"Student",-12}{"Internal",10}                                                            {"External",10}");
            Console.WriteLine("===================================");
            for (int student = 0; student < studentsCount; student++)
            {
                Console.Write($"Student{student + 1:00}");
                for (int sub = 0; sub < 2; sub++)
                {
                    Console.Write($"{Marks[student, sub],10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================================");

            Console.ReadKey();
        }
    }
}
