using CoffeeShopHRM.Api.Models;
using CoffeeShopHRM.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return View();
        }

        // GET: api/employee/5
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok();
        }

        // POST: api/employee/CreateEmployee
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            if (employee is null)
            {
                return BadRequest();
            }
            if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdEmployee = _employeeRepository.AddEmployee(employee);

            return Created("employee", createdEmployee);
        }


        // PUT: api/employee
        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            if (employee is null)
            {
                return BadRequest();
            }
            if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeToUpdate = _employeeRepository.GetEmployeeById(employee.EmployeeId);

            if (employeeToUpdate is null)
            {
                return NotFound();
            }

            _employeeRepository.UpdateEmployee(employee);

            return NoContent();
        }

        // DELETE: api/employee
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            if (id is 0)
            {
                return BadRequest();
            }

            var employeeToDelete = _employeeRepository.GetEmployeeById(id);
            if (employeeToDelete is null)
            {
                return NotFound();
            }

            _employeeRepository.DeleteEmployee(id);

            return NoContent();
        }
    }
}
