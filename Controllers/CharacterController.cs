global using dontet_rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dontet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character mercenary = new Character();
        [HttpGet]

        public ActionResult<Character> Get() {
            return Ok(mercenary);
        }
    }
}