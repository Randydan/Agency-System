using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomInterface _classroomInterface;

        public ClassroomController(IClassroomInterface classroomInterface)
        {
            _classroomInterface = classroomInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Classroom>))]

        public IActionResult GetClassrooms()
        {
            var classroom = _classroomInterface.GetClassrooms();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(classroom);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Classroom>))]

        public IActionResult GetClassroom(int Id)
        {
            if (!_classroomInterface.ClassroomExists(Id))
                return NotFound();

            var classroom = _classroomInterface.GetClassroom(Id);

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(classroom);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateAdministrators([FromBody] Classroom classroomcreate)
        {
            if (classroomcreate == null)
                return BadRequest(ModelState);

            var classroom = _classroomInterface.GetClassrooms()
                .Where(p => p.Name.Trim().ToUpper() == classroomcreate.Name
                .TrimEnd().ToUpper()).FirstOrDefault();

            if (classroom != null)
            {
                ModelState.AddModelError("", "Classroom already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_classroomInterface.CreateClassrooms(classroomcreate))
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

        public IActionResult UpdateClassroom(int Id, [FromBody] Classroom updateClassroom)
        {
            if (updateClassroom == null)
                return BadRequest(ModelState);

            if (Id != updateClassroom.ID)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_classroomInterface.ClassroomExists(Id))
                return NotFound();

            if (!_classroomInterface.UpdateClassroom(updateClassroom))
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

        public IActionResult DeleteClassroom(int Id)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_classroomInterface.ClassroomExists(Id))
                return NotFound();

            var classroom = _classroomInterface.GetClassroom(Id);

            if (!_classroomInterface.DeleteClassroom(classroom))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }
    }
}
