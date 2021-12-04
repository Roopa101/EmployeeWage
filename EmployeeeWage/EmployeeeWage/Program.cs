using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int ratePerHrs = 20;
        public static void Main(string[] args)
        {

            int empWage = 0;
            int empHrs = 0;
            string typeOfEmp = "";

            Random employee = new Random();
            int randomInput = employee.Next(0, 3);

            switch (randomInput)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = ratePerHrs * empHrs;
            Console.WriteLine(typeOfEmp + "  Wage per day is :" + empWage);
            Console.ReadLine();
        }
    }
}