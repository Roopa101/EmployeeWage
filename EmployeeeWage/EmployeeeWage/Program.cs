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
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("reliance", 10, 4, 20);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString());
            Console.ReadLine();
        }
    }
}