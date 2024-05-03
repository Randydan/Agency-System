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
    public class OfficeController : Controller
    {
        private readonly IOfficeInterface _officesInterface;
        private readonly IMapper _mapper;
        public OfficeController(IOfficeInterface officeRepository, IMapper mapper)
        {
            _officesInterface = officeRepository;
            _mapper = mapper;
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

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public IActionResult createStudent([FromBody] OfficeDTO officeCreate)
        {
            if (officeCreate == null)
                return BadRequest(ModelState);

            var office = _officesInterface.GetOffices()
            .Where(c => c.Description.Trim().ToUpper() == officeCreate.Description.TrimEnd().ToUpper()).FirstOrDefault();

            if (office != null)
            {
                ModelState.AddModelError("", "Office Already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var officeMap = _mapper.Map<Office>(officeCreate);

            if (!_officesInterface.createOffice(officeMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully Created");
        }

    }
}
