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
    public class CoursesController : Controller
    {
        private readonly ICourseInterface _courseInterface;
        public CoursesController(ICourseInterface courseRepository)
        {
            _courseInterface = courseRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Course>))]
        public IActionResult GetCourses()
        {
            var courses = _courseInterface.GetCourses();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(courses);
        }

        [HttpGet("{Code}")]
        [ProducesResponseType(200, Type = typeof(Course))]
        [ProducesResponseType(400)]

        public IActionResult GetCourse(String Code)
        {
            if (!_courseInterface.CourseExists(Code))
                return NotFound();

            var courses = _courseInterface.GetCourses();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(courses);
        }

        [HttpGet("{Name}")]
        [ProducesResponseType(200, Type = typeof(Course))]
        [ProducesResponseType(400)]

        public IActionResult GetCourses(string Name)
        {
            if (!_courseInterface.CourseExists(Name))
                return NotFound();

            var courses = _courseInterface.GetCourses();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(courses);
        }
    }
}
