using EmployeeCodeEF.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCodeEF.DBContextData
{
    public class EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
