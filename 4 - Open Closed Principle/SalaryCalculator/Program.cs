using System;
using SalaryCalculator.Models;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Freelancer");
            Employee employee2 = new Employee("FullTime");

            SalaryCalculator salaryCalculator = new SalaryCalculator();
            double salary1 = salaryCalculator.CalculateSalary(employee1);
            double salary2 = salaryCalculator.CalculateSalary(employee2);

            Console.WriteLine("Employee 1 = " + salary1);
            Console.WriteLine("Employee 2 = " + salary2);
        }
    }
}
