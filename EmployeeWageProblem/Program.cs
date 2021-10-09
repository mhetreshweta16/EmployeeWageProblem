using System;

namespace EmployeeWageProblem
{
    class Program
    {
        public const int EmpRatePerHrs= 20;
        public const int IS_FullTime = 1;
        public const int IS_PartTime = 2;
        public const int Num_Of_Working_Days = 20;
        public const int WorkingHrs = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            int empHrs = 0, totalEmpHrs = 0;
            int totalEmpWage = 0;
            int day = 1;
            while( day <= Num_Of_Working_Days && totalEmpHrs <= WorkingHrs )
            {
                Random r = new Random();
                int empInput = r.Next(0, 3);
                //Console.WriteLine(empInput);
                switch (empInput)
                {

                    case IS_FullTime:
                        //Console.WriteLine("Employee is Present");
                        empHrs = 8;
                        break;

                    case IS_PartTime:
                        //Console.WriteLine("Employee is Present");
                        empHrs = 4;
                        break;

                    default:
                        //Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                
                int empWage = EmpRatePerHrs * empHrs;
                totalEmpWage += empWage;
                Console.WriteLine("daily Employee Wage for {0} day {1}", day, empWage);
                totalEmpHrs += empHrs;
                day++;
            }

            Console.WriteLine("total employee wage for {0} day {1} Max Work Hrs{2} ",day-1, totalEmpWage,totalEmpHrs);
            Console.ReadLine();

        }
    }
}
