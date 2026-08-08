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
        public bool PostEmployees(Employee emp)
        {
            _context.Employees.Add(emp);
            var contextSaveStatus = _context.SaveChanges();
            // contextSaveStatus;
            return contextSaveStatus > 0;

        }
        public Employee? GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }
        public bool updateEmployeesData(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.Id);

            if (existingEmployee == null)
            {
                return false;
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Role = employee.Role;

            return _context.SaveChanges() > 0;


        }
    }
}