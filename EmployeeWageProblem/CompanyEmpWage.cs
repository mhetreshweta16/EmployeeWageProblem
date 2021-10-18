using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{

    public interface IComputeEmpWage
    {
        /// <summary>
        /// only declaration of method not implimentation 
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="EmpRatePerHrs">The emp rate per HRS.</param>
        /// <param name="Num_Of_Working_Days">The number of working days.</param>
        /// <param name="WorkingHrs">The working HRS.</param>
        public void addCompanyEmpWage(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs); 
        public void ComputeEmpWage();

        public int getTotalWage(string company);
    
    }
   public class CompanyEmpWage
    {
       public string company;
       public int EmpRatePerHrs;
        public int Num_Of_Working_Days;
        public int WorkingHrs;
        public int totalEmpWage ;



        public CompanyEmpWage(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {
            this.company = company;
            this.EmpRatePerHrs = EmpRatePerHrs;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.WorkingHrs = WorkingHrs;
            this.totalEmpWage = 0;

        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        
        }

        public string toString()
        {
            return "Total Emp Wage for Company :" + this.company + " is " + this.totalEmpWage;

            
        }


    }
}
