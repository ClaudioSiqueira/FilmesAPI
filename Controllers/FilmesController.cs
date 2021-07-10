using FilmesAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Filme> AdicionarFilme([FromBody] Filme filme)
        {
            return Ok(filme);
        }   
    }
}
