using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using classdotnet.Models;
using classdotnet.Services.CharacterService;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace classdotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> GetAll()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("GetOne/{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }
        
        [HttpPost("CreateOne")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}