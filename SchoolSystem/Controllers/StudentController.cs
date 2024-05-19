using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentInterface _studentInterface;

        public StudentController(IStudentInterface studentInterface)
        {
            _studentInterface = studentInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]

        public IActionResult GetStudents()
        {
            var student = _studentInterface.GetStudents();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(student);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateStudent([FromBody] Student studentcreate)
        {
            if (studentcreate == null)
                return BadRequest(ModelState);

            var student = _studentInterface.GetStudents()
                .Where(p => p.Name.Trim().ToUpper() == studentcreate.Name
                .TrimEnd().ToUpper()).FirstOrDefault();

            if (student != null)
            {
                ModelState.AddModelError("", "Student already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_studentInterface.CreateStudent(studentcreate))
            {
                ModelState.AddModelError("", "Something went wrong");

                return StatusCode(500, ModelState);
            }

            return Ok("Successfully Ceated");
        }

        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]

        public IActionResult UpdateStudent(string Matricule, [FromBody] Student updateStudent)
        {
            if (updateStudent == null)
                return BadRequest(ModelState);

            if (Matricule != updateStudent.Matricle)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_studentInterface.StudentsExists(Matricule))
                return NotFound();

            if (!_studentInterface.UpdateStudent(updateStudent))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

    }
}
