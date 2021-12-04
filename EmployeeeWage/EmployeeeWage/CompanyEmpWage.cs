using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeWage
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int ratePerHrs, int NO_OF_WORKING_Days, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int getTotalWage(string company);

    }
    public class CompanyEmpWage
    {
        public string company;
        public int ratePerHrs;
        public int NO_OF_WORKING_Days;
        public int MAX_HRS_IN_Month;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int ratePerHrs, int NO_OF_WORKING_Days, int MAX_HRS_IN_Month)
        {
            this.company = company;
            this.ratePerHrs = ratePerHrs;
            this.NO_OF_WORKING_Days = NO_OF_WORKING_Days;
            this.MAX_HRS_IN_Month = MAX_HRS_IN_Month;

        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Employee wage for company" + this.company + "is " + this.totalEmpWage;
        }
    }
}