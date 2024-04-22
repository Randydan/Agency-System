﻿using Classes.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
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
        public DepartmentController (IDepartmentInterface departmentRepository)
        {
                _departmentInterface = departmentRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Department>))]
        public IActionResult GetDepartments()
        {
            var department = _departmentInterface.GetDepartments();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(department);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(200, Type = typeof(Department))]
        [ProducesResponseType(400)]

        public IActionResult GetDepartment(int ID)
        {
            if (!_departmentInterface.DepartmentExists(ID))
                return NotFound();

            var departments = _departmentInterface.GetDepartments();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(departments);
        }

        /*[HttpGet("{Description}")]
        [ProducesResponseType(200, Type = typeof(Department))]
        [ProducesResponseType(400)]

        public IActionResult GetDepartment(string Description)
        {
            if (!_departmentInterface.DepartmentExists(Description))
                return NotFound();

            var department = _departmentInterface.GetDepartments();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(department);
        }*/

    }
}