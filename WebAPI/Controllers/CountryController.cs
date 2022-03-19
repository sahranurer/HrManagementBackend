using Business.Abstract;
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
    public class CountryController : ControllerBase
    {
        ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var results = _countryService.GetAll();
            if (results.Success)
            {
                return Ok(results);
            }
            return BadRequest(results);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _countryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcountriesbyregionId")]
        public IActionResult GetCountriesByRegionId(int id)
        {
            var result = _countryService.GetCountriesByRegionId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
