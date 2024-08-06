using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using classdotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace classdotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Murat"}            

        };

        [HttpGet("GetAll")] 
        public ActionResult<List<Character>> GetAll(){
            return Ok(characters);
        }

        [HttpGet("GetOne/{id}")]
        public ActionResult<Character> GetSingle(int id23){
            return Ok(characters.FirstOrDefault(c => c.Id == id23));
        }
    }
}