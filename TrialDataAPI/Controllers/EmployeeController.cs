using Microsoft.AspNetCore.Mvc;
using TrialDataAPI.Models;
using TrialDataAPI.Services.Interfaces;
using TrialDataAPI.ViewModel;

namespace TrialDataAPI.Controllers
{
    [Route("/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }


        [HttpPost]
        public IActionResult Create([FromBody] EmployeeViewModel employeeView)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = new Employee
            {
                Name = employeeView.Name,
                Age = employeeView.Age
            };

            var createdEmployee = _employee.Create(employee);

            return Ok(createdEmployee);
        }


        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employee.GetAll();
            return Ok(employees);
        }
    }
}
