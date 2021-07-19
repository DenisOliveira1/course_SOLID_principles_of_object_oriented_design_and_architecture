using SalaryCalculator.Models;

namespace SalaryCalculator.Calculator
{
    public class TaxCalculatorFullTime : ITaxCalculator
    {
        public double CalculateTax(Employee employee)
        {
            return 200;
        }
    }
}