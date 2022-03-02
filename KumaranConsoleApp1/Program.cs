using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaranConsoleApp1
{
    class EmployeeDetails
    {
        
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public int Salary { get; set; }

        public void GetEmpInformation(int EmpId,string Name,string Dept,string Desig,int Salary)
        {
            this .EmpId = EmpId;
            this .Name = Name;
            this .Dept = Dept;
            this .Desig = Desig;
            this .Salary = Salary;
        }
        public void DisplayEmpInformation()
        {
            Console.WriteLine(this.EmpId+"\t"+this.Name+"\t"+this.Dept+"\t"+this.Desig+"\t"+this.Salary);
        }

    }
    class Program 
    {
        static void Main(string[] args)
        {

            EmployeeDetails[] emp = new EmployeeDetails[10];
            Console.WriteLine("Enter the Num of Employee");

            int NumOfEmp = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < NumOfEmp; i++)
            {
                emp[i] = new EmployeeDetails();
                Console.WriteLine($"Employee Detail {i+1}\n");
                Console.Write("Enter your Id: ");
                int EmpId = int.Parse(Console.ReadLine());
                Console.Write("\nEnter your Name: ");
                string Name = Console.ReadLine();
                Console.Write("\nEnter your DepartmentName: ");
                string Dept = Console.ReadLine();
                Console.Write("\nEnter your Designation: ");
                string Desig = Console.ReadLine();
                Console.Write("\nEnter your BasicPay:");
                int Salary = int.Parse(Console.ReadLine());
                emp[i].GetEmpInformation(EmpId,Name,Dept,Desig,Salary);
            }
            int sum=0;
            Console.WriteLine("*************************************************************");
            Console.WriteLine("ID \t Name \t Department \t Designation \t Salary");
            Console.WriteLine("*************************************************************");
            for(int i = 0; i < NumOfEmp; i++)
            {
                emp[i].DisplayEmpInformation();
                sum=sum+emp[i].Salary;
            }
            Console.WriteLine("*************************************************************");
            Console.WriteLine("\t \t \t Total Salary: "+sum);
            Console.ReadKey();
        }
    }
}

