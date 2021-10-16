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
            Console.WriteLine("Welcome to Employee Wage Computation!\n");
            EmpWageCompute emp = new EmpWageCompute("DMart", 20, 20, 60);
            EmpWageCompute emp1 = new EmpWageCompute("Reliance", 20, 15, 30);
            // emp.empWageCompute("DMart",20, 20, 60);
            //emp1.empWageCompute("Reliance", 20, 15, 30);
            emp.empWageCompute();
            Console.WriteLine(emp.toString());
            emp1.empWageCompute();
            Console.WriteLine(emp1.toString());





        }
    
    }
}
