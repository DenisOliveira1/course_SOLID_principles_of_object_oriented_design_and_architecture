using SalaryCalculator.Calculator;
using SalaryCalculator.Models;

namespace SalaryCalculator
{
    public class SalaryCalculator
    {

        public TaxCalculatorFactory taxCalculatorFactory { get; set; }

        public double CalculateSalary(Employee employee){

            taxCalculatorFactory = new TaxCalculatorFactory();
            ITaxCalculator taxCalculator =  taxCalculatorFactory.NewTaxCalculator(employee);

            return taxCalculator.CalculateTax(employee);
        }
    }
}