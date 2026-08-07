using HRMS.Api.Data;
using HRMS.Api.Interfaces;
using HRMS.Api.Models;

namespace HRMS.Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRMSDbContext _context;

        public EmployeeRepository(HRMSDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
        public bool PostEmployees(Employee emp)
        {
            _context.Employees.Add(emp);
            var contextSaveStatus= _context.SaveChanges();
           // contextSaveStatus;
            return contextSaveStatus > 0 ;
            
        }
        public Employee? GetEmployeeById(int id)
        {
            var didFind = _context.Employees.Find(id);
            return didFind;

        }
    }
}