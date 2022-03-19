using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var results = _departmentService.GetAll();
            if (results.Success)
            {
                return Ok(results);
            }
            return BadRequest(results);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _departmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdepartmentbylocationid")]
        public IActionResult GetCountriesByRegionId(int id)
        {
            var result = _departmentService.GetDepartmentaByLocationId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Department department)
        {
            var result = _departmentService.Add(department);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Department department)
        {
            var result = _departmentService.Delete(department);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Department department)
        {
            var result = _departmentService.Update(department);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
