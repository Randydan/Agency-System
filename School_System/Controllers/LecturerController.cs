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
    public class LecturersController : Controller
    {
        private readonly ILecturerInterface _lecturersInterface;
        private readonly IMapper _mapper;
        public LecturersController(ILecturerInterface lecturerRepository, IMapper mapper)
        {
            _lecturersInterface = lecturerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Lecturer>))]
        public IActionResult GetLecturers()
        {
            var lecturers = _lecturersInterface.GetLecturers();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(lecturers);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public IActionResult createStudent([FromBody] LecturerDTO lecturerCreate)
        {
            if (lecturerCreate == null)
                return BadRequest(ModelState);

            var lecturer = _lecturersInterface.GetLecturers()
            .Where(c => c.Name.Trim().ToUpper() == lecturerCreate.Name.TrimEnd().ToUpper()).FirstOrDefault();

            if (lecturer != null)
            {
                ModelState.AddModelError("", "Student Already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var lecturerMap = _mapper.Map<Lecturer>(lecturerCreate);

            if (!_lecturersInterface.createLecturer(lecturerMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully Created");
        }

    }
}
