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
    public class LocationController : ControllerBase
    {
        ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var results = _locationService.GetAll();
            if (results.Success)
            {
                return Ok(results);
            }
            return BadRequest(results);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _locationService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getlocationbycountryid")]
        public IActionResult GetCountriesByRegionId(string id)
        {
            var result = _locationService.GetLocationsByCountryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Location location)
        {
            var result = _locationService.Add(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Location location)
        {
            var result = _locationService.Delete(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Location location)
        {
            var result = _locationService.Update(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
