using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Model
{
    namespace EmployeeSystem.Model
    {
        public class Employee
        {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Position { get; set; }

            [Required]
            [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid salary")]
            public decimal Salary { get; set; }
        }
    }
}