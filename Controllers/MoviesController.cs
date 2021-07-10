using Movies.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Movie> AddMovie([FromBody] Movie movie)
        {
            var validator = new MovieValidator();
            var result = validator.Validate(movie);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            return Ok(movie);
        }   
    }
}
