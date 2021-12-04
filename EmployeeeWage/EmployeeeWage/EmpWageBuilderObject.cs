using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeWage
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int ratePerHrs;
        private int NO_OF_WORKING_Days;
        private int MAX_HRS_IN_MONTH;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int ratePerHrs, int NO_OF_WORKING_Days, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.ratePerHrs = ratePerHrs;
            this.NO_OF_WORKING_Days = NO_OF_WORKING_Days;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;

        }
        public void ComputeEmpWage()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;

            int totalWorkingDays = 0;

            //computation
            while (totalEmpHrs <= this.MAX_HRS_IN_MONTH && totalWorkingDays < this.NO_OF_WORKING_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {

                    case IS_PART_TIME:
                        empHrs = 4;

                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;

                        break;

                    default:
                        empHrs = 0;

                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + " Emphrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * this.ratePerHrs;
            Console.WriteLine("Total Employee wage for company " + company + ": is " + totalEmpWage);

        }

        public string toString()
        {
            return "Total Employee wage for company" + this.company + "is " + this.totalEmpWage;
        }
    }
}


