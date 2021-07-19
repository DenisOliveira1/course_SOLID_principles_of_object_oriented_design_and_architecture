namespace SalaryCalculator.Models
{
    public class Employee
    {
        private string type;

        // Getters e setters
        public string Type { get => type;}

        // Construtor
        public Employee(string type)
        {
            this.type =  type;
        }
    }

}