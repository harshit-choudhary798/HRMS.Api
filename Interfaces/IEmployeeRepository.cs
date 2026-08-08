using HRMS.Api.Models;

namespace HRMS.Api.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
        public bool PostEmployees(Employee emp);
        public Employee? GetEmployeeById(int id);
        public bool updateEmployeesData(Employee emp);

    }
}