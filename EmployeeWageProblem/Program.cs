using System;

namespace EmployeeWageProblem
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            int IS_Present = 1;
            Random r = new Random();
            int empInput = r.Next(0, 2);
            Console.WriteLine(empInput);
            if (IS_Present == empInput)
            {
                
                Console.WriteLine("Employee is Present");
            }
            else {
                
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
