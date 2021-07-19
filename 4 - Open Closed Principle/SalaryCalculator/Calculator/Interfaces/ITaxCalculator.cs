using SalaryCalculator.Models;

namespace SalaryCalculator.Calculator{
    public interface ITaxCalculator
    {
        double CalculateTax(Employee employee);
    }
}