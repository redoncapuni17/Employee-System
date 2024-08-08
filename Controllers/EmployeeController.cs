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

        
        public async Task<List<Employee>> GetEmployees()
        {
            return await _dbContext.Employees.OrderByDescending(e=>e.Id).ToListAsync();
        }
        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<Employee>> SearchEmployeesByName(string name)
        {
            return await _dbContext.Employees.Where(e=>e.Name.Contains(name)).ToListAsync();
        }

        public async Task AddEmployee(Employee employee)
        {
            // Check if an employee with the same name already exists
            var existingEmployee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Name == employee.Name);
            if (existingEmployee != null)
            {
                throw new InvalidOperationException("An employee with the same name already exists.");
            }

            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteEmployee(int id)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (employee != null) 
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
