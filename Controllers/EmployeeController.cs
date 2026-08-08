using HRMS.Api.Interfaces;
using HRMS.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _service.GetEmployees();
                return NotFound();
        }
            [HttpPost]
            public IActionResult PostEmployees(Employee emp)
            {
                return Ok(_service.PostEmployees(emp));
            }
            [HttpGet("{id}")]
            public ActionResult<Employee> GetEmployeeById(int id)
            {
                var employee = _service.GetEmployeeById(id);

                if (employee == null)
                {
                    return NotFound();
                }

                return Ok(employee);
            } }
        [HttpPut("{id}")]
        public ActionResult<Employee> updateEmployeesData(Employee employee)
        {
            var employeeStatus = _service.updateEmployeesData(employee);

            if (employeeStatus == false)
            {
                return NotFound();
            }

            return Ok(employee);
        }

    }
}