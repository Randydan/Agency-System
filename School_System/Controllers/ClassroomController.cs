using AutoMapper;
using Classes.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using School_System.DTO;
using School_System.Interfaces;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace School_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomsController : Controller
    {
        private readonly IClassroomInterface _classroomInterface;
        private readonly IMapper _mapper;
        public ClassroomsController(IClassroomInterface classroomRepository, IMapper mapper)
        {
            _classroomInterface = classroomRepository;

            _mapper = mapper;
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

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateClassroom([FromBody] ClassroomDTO classroomCreate)
        {
            if (classroomCreate == null)
                return BadRequest(ModelState);
            var classroom = _classroomInterface.GetClassrooms()
                .Where(c => c.Description.Trim().ToUpper() == classroomCreate.Description.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (classroom != null)
            {
                ModelState.AddModelError("", "Classroom already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var classMap = _mapper.Map<Classroom>(classroomCreate);

            if (!_classroomInterface.createClassroom(classMap))
            {
              ModelState.AddModelError("", "Something went wrong while saving");
            return StatusCode(500, ModelState);
            }

               return Ok("Successfully Created");
        }

    }
}
