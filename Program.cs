using System;

namespace EmployeesWageProgram
{
    class Program
    {

        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Wage_Per_Hour = 20;
        public const int Working_Days = 20;
        public const int Max_Hours_Per_Month = 100;

        static void Main(string[] args)
        {
            CalculateMonthlyWage();
        }
        public static void CalculateMonthlyWage()
        {
            Console.WriteLine("Welcome Employee");

            var wageHour = 0;
            var monthlyWage = 0;
            var totalHours = 0;
            var totalWorkingDays = 0;
            while (totalHours <= Max_Hours_Per_Month && totalWorkingDays <= Working_Days)
            {
                totalWorkingDays++;
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
                totalHours += wageHour;
            }
            monthlyWage = totalHours * Wage_Per_Hour;
            Console.WriteLine("Employee's monthly Wage is : " + monthlyWage);
        }
    }
}