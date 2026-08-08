using HRMS.Api.Models;

namespace HRMS.Api.Interfaces
{
    public interface IEmployeeService
    {
        public Task<List<Employee>> GetEmployees();
        public bool PostEmployees(Employee emp);
        public Employee GetEmployeeById(int id);
        public bool updateEmployeesData(Employee employee);
    }
}