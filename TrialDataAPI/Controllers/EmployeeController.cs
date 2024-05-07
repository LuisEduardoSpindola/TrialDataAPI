using Microsoft.AspNetCore.Authorization;
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
        private readonly ILogger<EmployeeController> _logger;


        public EmployeeController(IEmployee employee, ILogger<EmployeeController> logger)
        {
            _employee = employee;
            _logger = logger;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create([FromForm] EmployeeViewModel employeeView)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var filePath = Path.Combine("Storage", employeeView.Photo.FileName);
            Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);

            var employee = new Employee
            {
                Name = employeeView.Name,
                Age = employeeView.Age,
                Photo = filePath,
            };

            var createdEmployee = _employee.Create(employee);

            return Ok(createdEmployee);
        }

        [HttpGet]
        public IActionResult Get(int pageNumber, int qnty)
        {
            //_logger.Log(LogLevel.Error, "Erro...");
            var employees = _employee.GetAll(pageNumber, qnty);
            return Ok(employees);
            
        }

        [HttpPost]
        [Route("{id}/download")]
        public IActionResult GetPhotoByDownload(int id) 
        {
            var employee = _employee.GetById(id);
            var databytes = System.IO.File.ReadAllBytes(employee.Photo);
            return File(databytes, "image/png");
        }
    }
}
