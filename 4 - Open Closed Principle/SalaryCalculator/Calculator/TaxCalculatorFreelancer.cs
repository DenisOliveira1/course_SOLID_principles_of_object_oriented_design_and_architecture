using SalaryCalculator.Models;

namespace SalaryCalculator.Calculator
{
    public class TaxCalculatorFreelancer : ITaxCalculator
    {
        public double CalculateTax(Employee employee)
        {
            return 100;
        }
    }
}