﻿using System;

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
            int empHrs= 0;

            Random r = new Random();
            int empInput = r.Next(0, 3);
            Console.WriteLine(empInput);
            if (IS_FullTime == empInput)
            {

                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (IS_PartTime == empInput)
            {

                Console.WriteLine("Employee is Present");
                empHrs = 4;
            }
            else {

                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            int empWage = EmpRatePerHrs * empHrs;
            Console.WriteLine("the Employee age is {0}", empWage);
            Console.ReadLine();



        }
    }
}
