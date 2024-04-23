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
        public LecturersController(ILecturerInterface lecturerRepository)
        {
            _lecturersInterface = lecturerRepository;
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

    }
}
