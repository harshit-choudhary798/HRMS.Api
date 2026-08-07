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

        public List<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }
        public bool PostEmployees(Employee emp)
        {
            return _repository.PostEmployees(emp);
        }
        public Employee? GetEmployeeById(int id)
        {
            return _repository.GetEmployeeById(id);
        }
    }
}