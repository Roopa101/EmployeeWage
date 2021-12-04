using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Problem");
            int isPresent = 1;

            Random employee = new Random();
            int randomInput = employee.Next(0, 2);

            if (randomInput == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
                Console.ReadLine();
        } 
    }
}
      