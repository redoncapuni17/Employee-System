using EmployeeSystem.Data;
using EmployeeSystem.Model.EmployeeSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSystem.Controllers
{
    public class EmployeeController
    {
        private readonly AppDbContext _dbContext;

        public EmployeeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
        }
    }
}
