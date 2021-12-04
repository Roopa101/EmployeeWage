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
        public const int NO_OF_WORKING_DAYS = 20;
        public static void Main(string[] args)
        {

            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            string typeOfEmp = "";

            for (int day = 0; day <= NO_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int randomInput = random.Next(0, 3);

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
                Console.WriteLine("{0} Emp of the day {1} Wage is {2} ", typeOfEmp, day, empWage);
                totalEmpWage = totalEmpWage + empWage;
            }
            Console.WriteLine("Employee Wage for {0} day is :{1}", NO_OF_WORKING_DAYS, totalEmpWage);
            Console.ReadLine();
        }
    }
}
