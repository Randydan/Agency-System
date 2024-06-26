﻿using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturerController : ControllerBase
    {
        private readonly ILecturerInterface _lecturerInterface;

        public LecturerController(ILecturerInterface lecturerInterface)
        {
            _lecturerInterface = lecturerInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Lecturer>))]

        public IActionResult GetLecturers()
        {
            var lecturer = _lecturerInterface.GetLecturers();

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(lecturer);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Lecturer>))]

        public IActionResult GetLecturers(int Id)
        {
            if (!_lecturerInterface.LecturerExists(Id))
                return NotFound();

            var lecturer = _lecturerInterface.GetLecturer(Id);

            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(lecturer);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateAdministrators([FromBody] Lecturer lecturercreate)
        {
            if (lecturercreate == null)
                return BadRequest(ModelState);

            var lecturer = _lecturerInterface.GetLecturers()
                .Where(p => p.Name.Trim().ToUpper() == lecturercreate.Name
                .TrimEnd().ToUpper()).FirstOrDefault();

            if (lecturer != null)
            {
                ModelState.AddModelError("", "Leecturer already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_lecturerInterface.CreateLecturer(lecturercreate))
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

        public IActionResult UpdateLecturer(int Id, [FromBody] Lecturer updateLecturer)
        {
            if (updateLecturer == null)
                return BadRequest(ModelState);

            if (Id != updateLecturer.Id)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_lecturerInterface.LecturerExists(Id))
                return NotFound();

            if (!_lecturerInterface.UpdateLecturer(updateLecturer))
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

        public IActionResult DeleteLecturer(int Id)
        {


            if (!ModelState.IsValid)
                return BadRequest();

            if (!_lecturerInterface.LecturerExists(Id))
                return NotFound();

            var lecturer = _lecturerInterface.GetLecturer(Id);

            if (!_lecturerInterface.DeleteLecturer(lecturer))
            {
                ModelState.AddModelError("", "Something went wrong");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }
    }
}
