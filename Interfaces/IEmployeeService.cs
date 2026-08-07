using HRMS.Api.Models;

namespace HRMS.Api.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        public bool PostEmployees(Employee emp);
        public Employee GetEmployeeById(int id);
    }
}