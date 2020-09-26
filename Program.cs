using System;

namespace EmployeesWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee");

            var UseCase = Convert.ToInt32(Console.ReadLine());
            var wagePerHour = 20;
            var fullDayHour = 8;
            var workingDays = 20;
            var numberOfHours = 100;
            switch (UseCase)
            {
                case 1:
                    Console.WriteLine(new Random().Next(0, 2) == 1 ? "Present" : "Absent");
                    break;
                case 2:

                    var dailyEmployeeWage = wagePerHour * fullDayHour;
                    Console.WriteLine("Daily Employee Wage is {0}", dailyEmployeeWage);
                    break;
                case 3:
                    Console.Write("Enter Part Time Wage Per Hour : ");
                    var partTimeWagePerHour = Convert.ToInt32(Console.ReadLine());
                    var partTimeHour = 8;
                    var partTimeWage = partTimeWagePerHour * partTimeHour;
                    Console.WriteLine("Part Time Wage is {0}", partTimeWage);
                    break;
                case 4:
                    dailyEmployeeWage = wagePerHour * fullDayHour;
                    var monthlyWage = dailyEmployeeWage * workingDays;
                    Console.WriteLine("Monthly Wage is {0}", monthlyWage);
                    break;
                case 5:
                    var modifiedMonthlyWage = wagePerHour * numberOfHours;
                    Console.WriteLine("Modified Monthly Wage is : {0}", modifiedMonthlyWage);
                    break;
            }
            Console.ReadLine();
        }
    }
}
