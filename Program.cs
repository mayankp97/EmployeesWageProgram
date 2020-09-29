using System;

namespace EmployeesWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee");

            var UseCase = Convert.ToInt32(Console.ReadLine());
            var isPartTime = true;
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
            if (UseCase == 3)
            {
                if(isPartTime==true){
                    Console.Write("Enter Part Time Wage Per Hour : ");
                    var partTimeWagePerHour = Convert.ToInt32(Console.ReadLine());
                    var partTimeHour = 8;
                    var partTimeWage = partTimeWagePerHour * partTimeHour;
                    Console.WriteLine("Part Time Wage is {0}", partTimeWage);
                }
                else
                    Console.WriteLine("Employee is not Part time", partTimeWage);
            }
        }
    }
}
