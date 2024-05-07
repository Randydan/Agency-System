using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        private readonly IAdministratorInterface _administratorInterface;

        public AdministratorController(IAdministratorInterface administratorInterface)
        {
            _administratorInterface = administratorInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Administrators>))]

        public IActionResult GetAdministrators()
        {
            var administrator= _administratorInterface.GetAdministrators();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(administrator);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateAdministrators([FromBody] Administrators administratorscreate)
        {
            if (administratorscreate == null)
                return BadRequest(ModelState);

            var administrator = _administratorInterface.GetAdministrators()
                .Where(p => p.Name.Trim().ToUpper() == administratorscreate.Name
                .TrimEnd().ToUpper()).FirstOrDefault();

            if (administrator != null)
            {
                ModelState.AddModelError("", "Administrator already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_administratorInterface.CreateAdministrator(administratorscreate))
            {
                ModelState.AddModelError("", "Something went wrong");

                return StatusCode(500, ModelState);
            }

            return Ok("Successfully Ceated");
        }
         
    }
}
