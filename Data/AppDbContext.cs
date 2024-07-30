using EmployeeSystem.Model.EmployeeSystem.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeeSystem.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<Employee> Employees { get; set; }
    }

}