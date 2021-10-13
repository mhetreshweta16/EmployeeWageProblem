using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class EmpWageCompute
    {
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






        public int empWageCompute(int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {

            int totalEmpHrs = 0;
            int totalEmpWage = 0;
            int day = 1;

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

            Console.WriteLine("total employee wage for {0} day {1} Max Work Hrs{2} ", day - 1, totalEmpWage, totalEmpHrs);
            Console.ReadLine();
            return 0;
        }

    }
}
