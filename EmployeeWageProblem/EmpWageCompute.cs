using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class EmpWageCompute
    {
        string company;
        int EmpRatePerHrs;
        int Num_Of_Working_Days;
        int WorkingHrs;
        int totalEmpWage = 0;

        public EmpWageCompute(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {
            this.company = company;
            this.EmpRatePerHrs = EmpRatePerHrs;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.WorkingHrs = WorkingHrs;
            
        }
        public int checkEmpTime(int empInput)
        {

            const int IS_FullTime = 1;
            const int IS_PartTime = 2;
            int empHrs = 0;

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
     public void empWageCompute()
        {

            int totalEmpHrs = 0;
           
            int day = 1;
            Console.WriteLine("Employee Wage Computation for {0}", company);
            while (day <= Num_Of_Working_Days && totalEmpHrs <= WorkingHrs)
            {
                Random r = new Random();
                int empInput = r.Next(0, 3);
                //Console.WriteLine(empInput);
                int empHrs = checkEmpTime(empInput);

                int empWage = EmpRatePerHrs * empHrs;
                totalEmpWage += empWage;
                Console.WriteLine("daily Employee Wage for {0} day {1}", day, empWage);
                totalEmpHrs += empHrs;
                day++;
            }

            Console.WriteLine("total employee wage for company {0} is {1} \n ", company, totalEmpWage);
         
            
            
        }
        public string toString()
        { 
           return "Total Emp Wage for Company :"+this.company+" is "+this.totalEmpWage;

            //Console.ReadLine();
        }
        

    }
}
