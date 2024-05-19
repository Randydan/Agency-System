using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeInterface _officeInterface;

        public OfficeController(IOfficeInterface officeInterface)
        {
            _officeInterface = officeInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Office>))]

        public IActionResult GetOffices()
        {
            var Office = _officeInterface.GetOffice();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(Office);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateOffices([FromBody] Office officecreate)
        {
            if (officecreate == null)
                return BadRequest(ModelState);

            var office = _officeInterface.GetOffice()
                .Where(p => p.Description.Trim().ToUpper() == officecreate.Description
                .TrimEnd().ToUpper()).FirstOrDefault();

            if (office != null)
            {
                ModelState.AddModelError("", "Office already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_officeInterface.CreateOffice(officecreate))
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

        public IActionResult UpdateOffice(int ID, [FromBody] Office updateOffice)
        {
            if (updateOffice == null)
                return BadRequest(ModelState);

            if (ID != updateOffice.ID)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_officeInterface.OfficeExists(ID))
                return NotFound();

            if (!_officeInterface.UpdateOffice(updateOffice))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

    }
}
