
global using KretaDx.BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace KretaDx.Controllers;

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]   
        [Route("employee")]
        public IActionResult GetEmployee()
        {
            var result=_employeeService.GetEmployees();
            return Ok(result);
        }
    }

