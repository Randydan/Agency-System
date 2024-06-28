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

        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]

        public IActionResult UpdateAdministrator(int Id, [FromBody]Administrators updateAdministrators)
        {
            if (updateAdministrators == null)
                return BadRequest(ModelState);
             
            if (Id != updateAdministrators.Id)
                return BadRequest(ModelState);

            if (!ModelState.IsValid) 
                return BadRequest();

            if (!_administratorInterface.AdministratorsExists(Id))
                return NotFound();

            if(!_administratorInterface.UpdateAdministrator(updateAdministrators))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Administrators>))]

        public IActionResult GetAdministrators(int Id)
        {
            if (!_administratorInterface.AdministratorsExists(Id))
                return NotFound();

            var admin = _administratorInterface.GetAdministrators(Id);

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(admin);
        }

        [HttpGet("Name")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Administrators>))]

        public IActionResult GetAdministrator(string name)
        {
            if (!_administratorInterface.AdministratorExist(name))
                return NotFound();

            var admin = _administratorInterface.GetAdministrator(name);

            if (!ModelState.IsValid)

            return BadRequest(ModelState);

           return Ok(admin);
        }

        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]

        public IActionResult DeleteAdministrator(int Id)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_administratorInterface.AdministratorsExists(Id))
                return NotFound();

            var administrator = _administratorInterface.GetAdministrators(Id);

            if (!_administratorInterface.DeleteAdministrator(administrator))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

    }
}
