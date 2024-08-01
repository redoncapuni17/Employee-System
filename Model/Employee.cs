using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Model.EmployeeSystem.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid salary")]
        public decimal Salary { get; set; }
    }
}