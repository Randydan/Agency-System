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
    public class AdministratorsController : Controller
    {
        private readonly IAdministratorsInterface _administratorsInterface;
        public AdministratorsController (IAdministratorsInterface administratorRepository)
        {
                _administratorsInterface = administratorRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Administrator>))]
        public IActionResult GetAdministrators()
        {
            var administrators = _administratorsInterface.GetAdministrators();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(administrators);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(200, Type = typeof(Administrator))]
        [ProducesResponseType(400)]

        public IActionResult GetAdministrator(int ID)
        {
            if (!_administratorsInterface.AdministratorExists(ID))
                return NotFound();

            var administrators = _administratorsInterface.GetAdministrators();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(administrators);
        }

        [HttpGet("{Name}")]
        [ProducesResponseType(200, Type = typeof(Administrator))]
        [ProducesResponseType(400)]

        public IActionResult GetAdminiistrator(string Name)
        {
            if (!_administratorsInterface.AdministratorExists(Name))
                return NotFound();

            var administrators = _administratorsInterface.GetAdministrators();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(administrators);
        }

    }
}
