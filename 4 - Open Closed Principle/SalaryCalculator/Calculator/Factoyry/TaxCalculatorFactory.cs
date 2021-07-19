using System;
using SalaryCalculator.Models;

namespace SalaryCalculator.Calculator
{
    public class TaxCalculatorFactory
    {
        public ITaxCalculator NewTaxCalculator(Employee employee){

            switch(employee.Type){
                case "Freelancer":
                    return new TaxCalculatorFreelancer();
                default:
                    return new TaxCalculatorFullTime();
            }
        }
    }
}