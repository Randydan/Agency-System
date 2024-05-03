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
    public class CoursesController : Controller
    {
        private readonly ICourseInterface _courseInterface;
        private readonly IMapper _mapper;
        public CoursesController(ICourseInterface courseRepository , IMapper mapper)
        {
            _courseInterface = courseRepository;
            _mapper = mapper;   

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

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public IActionResult CreateCourse (CourseDTO courseCreate)
        {
            if (courseCreate == null)
            return BadRequest(ModelState);
            var course = _courseInterface.GetCourses().Where(c => c.Description.Trim().ToUpper() == courseCreate.Description.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (course != null)
            {
                ModelState.AddModelError("", "Course already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var courseMap= _mapper.Map<Course>(courseCreate);

            if (!_courseInterface.CreateCourse(courseMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }
            return Ok("Successfully Created");
        }
    }
}
