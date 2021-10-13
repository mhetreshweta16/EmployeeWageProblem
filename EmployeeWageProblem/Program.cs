using System;

namespace EmployeeWageProblem
{
    class Program
    {
        //public const int EmpRatePerHrs= 20;
       
       // public const int Num_Of_Working_Days = 20;
        //public const int WorkingHrs = 60;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            EmpWageCompute emp = new EmpWageCompute();
            emp.empWageCompute(20, 20, 60);




        }
    
    }
}
