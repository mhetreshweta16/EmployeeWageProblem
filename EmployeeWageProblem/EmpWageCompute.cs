using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmpWageCompute : IComputeEmpWage
    {

        /// <summary>
        /// The company emp wage list
        /// </summary>
        ///  
        private LinkedList<CompanyEmpWage> companyEmpWageList;           //creating Empty LinkedList 
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;  //creating Empty Dictionary

        public EmpWageCompute()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, EmpRatePerHrs, Num_Of_Working_Days, WorkingHrs);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.empWageCompute(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());

            }


        }
        public int checkEmpTime(int empInput)
        {

            const int IS_FullTime = 1;
            const int IS_PartTime = 2;
            int empHrs ;

            switch (empInput)
            {
                case IS_FullTime:
                        return empHrs = 8;

                case IS_PartTime:

                    return empHrs = 4;

                default:

                    return empHrs = 0;
            }

        }

        private int empWageCompute(CompanyEmpWage companyEmpWage)
        {
             int totalEmpHrs = 0, empHrs = 0, totalWorkingDays = 0; 
         
            while (totalEmpHrs <= companyEmpWage.WorkingHrs && totalWorkingDays<companyEmpWage.Num_Of_Working_Days )
            {
                Random r = new Random();
        int empInput = r.Next(0, 3);
        //Console.WriteLine(empInput);
        empHrs = checkEmpTime(empInput);

        //int empWage = EmpRatePerHrs * empHrs;
        totalEmpHrs += empHrs;
                Console.WriteLine("Days:"+totalWorkingDays+"Emp Hrs: "+empHrs);
              
            }

            return totalEmpHrs* companyEmpWage.EmpRatePerHrs;

     }
        

            public int getTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalEmpWage;
            
            }

        
        
        

}


}
