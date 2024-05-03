using AutoMapper;
using Classes;
using Classes.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using School_System.Interfaces;
using School_System.Repository;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace School_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentInterface _departmentInterface;

        private readonly IMapper _mapper;
        public DepartmentController (IDepartmentInterface departmentRepository, IMapper mapper)
        {
                _departmentInterface = departmentRepository;
                _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Department>))]
        public IActionResult GetDepartments()
        {
            var department = _mapper.Map<List<DepartmentDTO>>(_departmentInterface.GetDepartments());

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(department);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public IActionResult createDepartment([FromBody] DepartmentDTO departmentCreate) 
        {
            if (departmentCreate == null)
                return BadRequest(ModelState);
            var department = _departmentInterface.GetDepartments()
                .Where(c => c.Description.Trim().ToUpper() == departmentCreate.Description.TrimEnd().ToUpper())
                .FirstOrDefault();
            if (departmentCreate != null)
            {
                ModelState.AddModelError("", "Department already exist");
                return StatusCode(422, ModelState);
            }

            if (ModelState.IsValid)
                return BadRequest(ModelState);
            var depMap = _mapper.Map<Department>(departmentCreate);
            if (!_departmentInterface.createDepartment(depMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully Created");
                
        }

    }
}
