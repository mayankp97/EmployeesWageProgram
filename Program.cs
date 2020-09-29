using System;

namespace EmployeesWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee");

            const int wagePerHour = 20;
            const int wageHour = 8;

            var isPresent = new Random().Next(0, 2) == 1;

            var dailyWage = 0;
            if (isPresent == true)
                dailyWage = wagePerHour * wageHour;



        }
    }
}
