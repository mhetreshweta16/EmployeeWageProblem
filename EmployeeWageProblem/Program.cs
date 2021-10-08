using System;

namespace EmployeeWageProblem
{
    class Program
    {
        public const int EmpRatePerHrs= 20;
        public const int IS_FullTime = 1;
        public const int IS_PartTime = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            int empHrs = 0;

            Random r = new Random();
            int empInput = r.Next(0, 3);
            Console.WriteLine(empInput);
            switch (empInput)
            {

                case IS_FullTime:
                    Console.WriteLine("Employee is Present");
                    empHrs = 8;
                    break;

                case IS_PartTime:
                    Console.WriteLine("Employee is Present");
                    empHrs = 4;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
     
           int empWage = EmpRatePerHrs * empHrs;
            Console.WriteLine("the Employee age is {0}", empWage);
            Console.ReadLine();



        }
    }
}
