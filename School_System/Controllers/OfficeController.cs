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
    public class OfficeController : Controller
    {
        private readonly IOfficeInterface _officesInterface;
        public OfficeController(IOfficeInterface officeRepository)
        {
            _officesInterface = officeRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Office>))]
        public IActionResult GetOffices()
        {
            var offices = _officesInterface.GetOffices();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(offices);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(200, Type = typeof(Office))]
        [ProducesResponseType(400)]

        public IActionResult GetOffice(int ID)
        {
            if (!_officesInterface.OfficeExists(ID))
                return NotFound();

            var offices = _officesInterface.GetOffices();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(offices);
        }

        [HttpGet("{Name}")]
        [ProducesResponseType(200, Type = typeof(Office))]
        [ProducesResponseType(400)]

        public IActionResult GetOffice(string Name)
        {
            if (!_officesInterface.OfficeExists(Name))
                return NotFound();

            var offices = _officesInterface.GetOffices();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(offices);
        }

    }
}
