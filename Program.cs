using System;

namespace EmployeesWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee");

            const int wagePerHour = 20;
            int wageHour = 0;

            var isPresent = new Random().Next(0, 2) == 1;
            var isPartTime = new Random().Next(0, 2) == 1;

            var dailyWage = 0;
            if (isPartTime)
                wageHour = 4;
            else if (isPresent)
                wageHour = 8;
            dailyWage = wageHour * wagePerHour;
        }
    }
}
