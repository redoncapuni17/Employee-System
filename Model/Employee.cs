using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Model.EmployeeSystem.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid salary")]
        public decimal Salary { get; set; }
    }
}