using AutoMapper;
using Classes;
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
            private readonly IMapper _mapper;
            public StudentsController(IStudentInterface studentRepository, IMapper mapper)
            {
                _studentsInterface = studentRepository;
                _mapper = mapper;
            }

            [HttpGet]
            [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
            public IActionResult GetStudents()
            {
                var students = _mapper.Map<List<StudentDTO>>(_studentsInterface.GetStudents());

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok(students);
            }
            [HttpPost]
            [ProducesResponseType(204)]
            [ProducesResponseType(422)]
            public IActionResult createStudent([FromBody] StudentDTO studentCreate)
            {
                if (studentCreate == null)
                return BadRequest(ModelState);

            var student = _studentsInterface.GetStudents()
            .Where(c => c.Name.Trim().ToUpper() == studentCreate.Name.TrimEnd().ToUpper()).FirstOrDefault();

            if (student != null)
            {
                ModelState.AddModelError("", "Student Already exists");
                return StatusCode(422, ModelState);
            }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var studentMap = _mapper.Map<Student>(studentCreate);

                if (!_studentsInterface.createStudent(studentMap))
                {
                    ModelState.AddModelError("", "Something went wrong while saving");
                    return StatusCode(500, ModelState);
                }

                return Ok("Successfully Created");
            }
            }

    }