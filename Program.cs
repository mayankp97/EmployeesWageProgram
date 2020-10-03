using System;

namespace EmployeesWageProgram
{
    class Program
    {

        
        

        static void Main(string[] args)
        {
            var walmart = new EmployeeWageBuilder("Walmart", 20, 21, 120);
            var Dtech = new EmployeeWageBuilder("Dtech", 42, 20, 140);
            walmart.CalculateMonthlyWage();
            Dtech.CalculateMonthlyWage();

        }
        
    }
}