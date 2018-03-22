using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play.API.Controllers
{
    [Route("api/[controller]")]
    public class SportsController : Controller
    {
        private readonly ISportsRepository _sportsRepository;
        public SportsController(ISportsRepository sportsRepository)
        {
            _sportsRepository = sportsRepository;
        }

        [HttpGet]
        public IActionResult GetAllAvailableSports()

        {
            try
            {
                var x = _sportsRepository.GetAllAvailableSports();
                return Ok(x);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetLocationBySportsId(int id)
        {
            try
            {
                var locations = _sportsRepository.GetLocationBySportsId(id);
                return Ok(locations);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
