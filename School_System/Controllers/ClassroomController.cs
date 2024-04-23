using Classes.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using School_System.Interfaces;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace School_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomsController : Controller
    {
        private readonly IClassroomInterface _classroomInterface;
        public ClassroomsController(IClassroomInterface classroomRepository)
        {
            _classroomInterface = classroomRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Classroom>))]
        public IActionResult GetClassrooms()
        {
            var classrooms = _classroomInterface.GetClassrooms();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(classrooms);
        }

    }
}
