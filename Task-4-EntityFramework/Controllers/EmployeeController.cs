using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_4_EntityFramework.Models;
using Task_4_EntityFramework.Services;

namespace Task_4_EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }
        [HttpGet("all")]
        public IActionResult Get()
        {
            try
            {
                var all = _employeeService.GetAll();
                return Ok(all);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("{id}")]
        public IActionResult Get_id(int id)
        {
            try
            {
                var emp = _employeeService.GetById(id);
                if (emp == null)
                {
                    throw new Exception("user not found");
                }
                return Ok(emp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            try
            {
                _employeeService.Post(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult update(int id, Employee employee)
        {
            try
            {
                var emp = _employeeService.Update(id, employee);
                if (emp == null)
                {
                    throw new Exception("Employee not found");
                }
                return CreatedAtAction(nameof(Get_id), new { id = emp.Emp_Id }, emp);
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not update {ex.Message}");
            }

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var del = _employeeService.Delete(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Get_sal(int sal)
        {
            try
            {
                var emp = _employeeService.Employ_sal(sal);
                if(emp == null)
                {
                    return BadRequest("Employee not found with this salary");
                }
                return Ok(emp);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}
