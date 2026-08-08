using HRMS.Api.Models;

namespace HRMS.Api.Interfaces
{
    public interface IEmployeeService
    {
            Task<List<Employee>> GetEmployees();
            Task<bool> PostEmployees(Employee emp);
            Task<Employee?> GetEmployeeById(int id);
            Task<bool> UpdateEmployeesData(Employee employee); 
    }
}