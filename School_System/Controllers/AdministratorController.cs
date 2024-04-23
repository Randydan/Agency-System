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

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateAdministrator([FromBody] Administrator administratorCreate)
        {
            if (administratorCreate == null)
                return BadRequest(ModelState);
            var administrator = _administratorsInterface.GetAdministrators()
                .Where(c => c.Name.Trim().ToUpper() == administratorCreate.Name.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (administrator != null)
            {
                ModelState.AddModelError("", "Administrator already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_administratorsInterface.createAdministrators(administratorCreate))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully Created");
        }
    }
}
