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
            return Ok(movie);
        }   
    }
}
