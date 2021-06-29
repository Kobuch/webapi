using Jppapi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Controllers
{

    public class UserCred
    {
        public string username { get; set; }
        public string password { get; set; }
    }


    [Authorize]
    [ApiController]
       
    [EnableCors("MyPolicy")]
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
            var user = authManager.Autenticate(userCred.username, userCred.password);
            if (user.Login == null)
                return Unauthorized();

            return Ok(user);
        }
        
        [HttpGet]
        public IEnumerable<string> Get([FromHeader] string login)
        {
            return new string[] { "test value", };
        }
    }
}
