using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeWage
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int ratePerHrs, int NO_OF_WORKING_Days, int MAX_HRS_IN_Month)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, ratePerHrs, NO_OF_WORKING_Days, MAX_HRS_IN_Month);
            numOfCompany++;

        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0;
            int totalEmpHrs = 0;

            int totalWorkingDays = 0;


            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Days :" + totalWorkingDays + " Emphrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;


        }



    }
}

