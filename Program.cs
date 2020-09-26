using System;

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
        }
    }
}
