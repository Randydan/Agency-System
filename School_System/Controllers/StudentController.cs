using Classes.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using School_System.Interfaces;
using School_System.Repository;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace School_System.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class StudentsController : Controller
        {
            private readonly IStudentInterface _studentsInterface;
            public StudentsController(IStudentInterface studentRepository)
            {
                _studentsInterface = studentRepository;
            }

            [HttpGet]
            [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
            public IActionResult GetStudents()
            {
                var students = _studentsInterface.GetStudents();

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok(students);
            }

        }
    }