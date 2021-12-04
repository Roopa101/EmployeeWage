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
        public const int MAX_HRS_IN_MONTH = 100;
        public static int ComputeEmpWage()
        {

            int empHrs = 0;
            int totalEmpHrs = 0;

            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NO_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "EmpprHr:" + empHrs);

            }

            int totalEmpWage = totalEmpHrs * ratePerHrs;
            Console.WriteLine("total Employee wage is :" + totalEmpWage);
            Console.ReadLine();
            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
            Console.ReadLine();
        }


    }

}