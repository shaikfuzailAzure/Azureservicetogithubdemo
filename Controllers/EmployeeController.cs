using AppserviceWebigithub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppserviceWebigithub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult getEmps()
        {
            var employees = new[]
            {
                new employee{Eno=1,Name="shaik fuzail"},
                new employee{Eno=2,Name="shaik suhail"},
                new employee{Eno=3,Name="shaik vazid"},
                new employee{Eno=4,Name="shaik mujahid"}
            };
            return Ok(employees);
        }
        [HttpGet("{eno}")]
        public IActionResult GetEmp(int eno)
        {
            var employees = new[]
            {
                new employee{Eno=1,Name="shaik fuzail"},
                new employee{Eno=2,Name="shaik suhail"},
                new employee{Eno=3,Name="shaik vazid"},
                new employee{Eno=4,Name="shaik mujahid"}
            };

            var emp = employees.FirstOrDefault(e => e.Eno == eno);

            if (emp == null)
                return NotFound();

            return Ok(emp);
        }
    }
}
