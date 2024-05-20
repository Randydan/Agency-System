using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseInterface _courseInterface;

        public CourseController(ICourseInterface courseInterface)
        {
            _courseInterface = courseInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Course>))]

        public IActionResult GetCourses()
        {
            var course = _courseInterface.GetCourses();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(course);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult Createcourses([FromBody] Course coursecreate)
        {
            if (coursecreate == null)
                return BadRequest(ModelState);

            var course = _courseInterface.GetCourses()
                .Where(p => p.Name.Trim().ToUpper() == coursecreate.Name
                .TrimEnd().ToUpper()).FirstOrDefault();

            if (course != null)
            {
                ModelState.AddModelError("", "Course already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_courseInterface.CreateCourse(coursecreate))
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

        public IActionResult UpdateCourse(int ID, [FromBody] Course updateCourse)
        {
            if (updateCourse == null)
                return BadRequest(ModelState);

            if (ID != updateCourse.ID)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_courseInterface.CourseExists(ID))
                return NotFound();

            if (!_courseInterface.UpdateCourse(updateCourse))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

    }
}
