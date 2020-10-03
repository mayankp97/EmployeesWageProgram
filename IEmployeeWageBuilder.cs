namespace EmployeesWageProgram
{
    interface IEmployeeWageBuilder
    {
        void AddWageDetails(string companyName, int wagePerHour, int workingDays, int maxHoursPerMonth);
        void CalculateMonthlyWage(CompanyEmployeeWage companyEmployeeWage);
        void ComputeWageForAll();
    }
}