using HRMS.Api.Data;
using HRMS.Api.Interfaces;
using HRMS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRMSDbContext _context;

        public EmployeeRepository(HRMSDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<bool> PostEmployees(Employee emp)
        {
            await _context.Employees.AddAsync(emp); // Add the new employee to the DbSet (we can use add or addAsync methods as add doesn't need to be awaited but addAsync is an async method and needs to be awaited)

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<bool> UpdateEmployeesData(Employee employee)
        {
            var existingEmployee =
                await _context.Employees.FindAsync(employee.Id);

            if (existingEmployee == null)
            {
                return false;
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Role = employee.Role;

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
