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

    }
}
