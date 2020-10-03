using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesWageProgram
{
    class EmployeeWageBuilder
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;

        private string _companyName;
        private int _wagePerHour;
        private int _workingDays;
        private int _maxHoursPerMonth;
        private int _totalEmployeeWage;

        public EmployeeWageBuilder(string companyName, int wagePerHour, int workingDays, int maxHoursPerMonth)
        {
            _companyName = companyName;
            _wagePerHour = wagePerHour;
            _workingDays = workingDays;
            _maxHoursPerMonth = maxHoursPerMonth;

        }
        public void CalculateMonthlyWage()
        {
            Console.WriteLine("Welcome Employee");

            var wageHour = 0;
            var totalHours = 0;
            var totalWorkingDays = 0;
            while (totalHours <= _maxHoursPerMonth && totalWorkingDays <= _workingDays)
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
            _totalEmployeeWage = totalHours * _wagePerHour;
            Console.WriteLine("Total Employee Wage for " + _companyName + " is " + _totalEmployeeWage);
        }

        public override string ToString()
        {
            return "Total Employee Wage for " + _companyName + " is " + _totalEmployeeWage;
        }


    }
}

