using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentInterface _departmentInterface;

        public DepartmentController(IDepartmentInterface departmentInterface)
        {
            _departmentInterface = departmentInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Department>))]

        public IActionResult GetDepartments()
        {
            var department = _departmentInterface.GetDepartments();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(department);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Department>))]

        public IActionResult GetDepartment(int Id)
        {
            if (!_departmentInterface.DepartmentExists(Id))
                return NotFound();

            var department = _departmentInterface.GetDepartment(Id);

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(department);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateDepartments([FromBody] Department departmentcreate)
        {
            if (departmentcreate == null)
                return BadRequest(ModelState);

            var department = _departmentInterface.GetDepartments()
                .Where(c => c.Name.Trim().ToUpper() == departmentcreate
                .Name.TrimEnd().ToUpper()).FirstOrDefault();

            if (department != null)
            {
                ModelState.AddModelError("", "Department already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_departmentInterface.CreateDepartment(departmentcreate))
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

        public IActionResult UpdateDepartment(int Id, [FromBody] Department updateDepartment)
        {
            if (updateDepartment == null)
                return BadRequest(ModelState);

            if (Id != updateDepartment.ID)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_departmentInterface.DepartmentExists(Id))
                return NotFound();

            if (!_departmentInterface.UpdateDepartment(updateDepartment))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }


        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]

        public IActionResult DeleteDepartment(int Id)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_departmentInterface.DepartmentExists(Id))
                return NotFound();

            var department = _departmentInterface.GetDepartment(Id);

            if (!_departmentInterface.DeleteDepartment(department))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }
    }
}
