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

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]

        public IActionResult GetStudent(int Id)
        {
            if (!_studentInterface.StudentsExists(Id))
                return NotFound();

            var student = _studentInterface.GetStudent(Id);

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

        public IActionResult UpdateStudent(int ID, [FromBody] Student updateStudent)
        {
            if (updateStudent == null)
                return BadRequest(ModelState);

            if (ID != updateStudent.ID)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_studentInterface.StudentsExists(ID))
                return NotFound();

            if (!_studentInterface.UpdateStudent(updateStudent))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }



        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]

        public IActionResult DeleteStudent(int ID)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_studentInterface.StudentsExists(ID))
                return NotFound();

            var student = _studentInterface.GetStudent(ID);

            if (!_studentInterface.DeleteStudent(student))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }
    }
}
