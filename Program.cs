﻿using System;

namespace EmployeesWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee");

            var UseCase = Convert.ToInt32(Console.ReadLine());
            if (UseCase == 1)
                Console.WriteLine(new Random().Next(0, 2) == 1 ? "Present" : "Absent");
            Console.ReadLine();
            if (UseCase == 2)
            {
                var wagePerHour = 20;
                var fullDayHour = 8;
                var dailyEmployeeWage = wagePerHour * fullDayHour;
                Console.WriteLine("Daily Employee Wage is {0}", dailyEmployeeWage);
            }
        }
    }
}
