using Jppapi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Controllers
{

    public class UserCred
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }


    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private readonly IAuthManager authManager;

        public NameController(IAuthManager authManager)
        {
            this.authManager = authManager;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Autenticate([FromBody] UserCred userCred)
        {   
            var user = authManager.Autenticate(userCred.Username, userCred.Password);
            if (user.Login == null)
                return Unauthorized();

            return Ok(user);
        }

        [HttpGet]
        public IEnumerable<string> Get([FromHeader] string login)
        {

            //   System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;

            return new string[] { "value", "value2" };

        }
    }
}
