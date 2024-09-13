using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {   public static List<Employee> employees = new List<Employee>();
        [HttpGet("get-employees")]
        public IEnumerable<Employee> GetEmployee()
        {
            return employees;
        }

        [HttpGet("get-employee")]
        public Employee GetEmployee(int id)
        {
            return employees.Where(x=>x.Id == id).FirstOrDefault();
            
        }

        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            employees.Add(employee);
            return Ok("Added");
        }
        [HttpPut]
        public IActionResult PutEmployee(Employee employee)
        {
            var newemp = employees.Where(x=>x.Id==employee.Id).FirstOrDefault();
            employees.Remove(newemp);
            employees.Add(employee);
            return Ok("Updated");
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(Employee employee)
        {
            var newemp = employees.Where(x => x.Id == employee.Id).FirstOrDefault();
            employees.Remove(newemp);
            return Ok("Deleted");
        }
    }
}
