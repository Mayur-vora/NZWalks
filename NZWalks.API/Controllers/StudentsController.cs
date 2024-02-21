using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // Get : https://localhost:port_number/api/Students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentnames = new string[] { "John", "Kushal", "May", "Diya", "Dev" };

            return Ok(studentnames);
        }
    }
}
