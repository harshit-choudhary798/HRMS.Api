using HRMS.Api.Interfaces;
using HRMS.Api.Models;

namespace HRMS.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _repository.GetEmployees();
        }

        public async Task<bool> PostEmployees(Employee emp)
        {
            return await _repository.PostEmployees(emp);
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _repository.GetEmployeeById(id);
        }

        public async Task<bool> UpdateEmployeesData(Employee employee)
        {
            return await _repository.UpdateEmployeesData(employee);
        }
    }
}
