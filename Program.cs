using System;

namespace EmployeesWageProgram
{
    class Program
    {

        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Wage_Per_Hour = 20;
        public const int Working_Days = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee");

            var wageHour = 0;
            var dailyWage = 0;
            var monthlyWage = 0;
            for (int days = 0; days < Working_Days; days++)
            {
                var empCheck = new Random().Next(0, 3);
                switch (empCheck)
                {
                    case IS_Part_Time:
                        wageHour = 4;
                        break;
                    case IS_Full_Time:
                        wageHour = 8;
                        break;
                    default:
                        wageHour = 0;
                        break;
                }
                dailyWage = wageHour * Wage_Per_Hour;
                monthlyWage += dailyWage;
            }
            Console.WriteLine("Employee's monthly Wage is : " + dailyWage);
        }
    }
}