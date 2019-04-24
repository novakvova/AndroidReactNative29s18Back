using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndroidBack29s18.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AndroidBack29s18.Controllers
{
    
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Post([FromBody] LoginViewModel model)
        {
            return Ok(new { semen="Дякую" });
        }
    }
}