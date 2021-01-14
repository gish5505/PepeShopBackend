using Microsoft.AspNetCore.Mvc;
using PepeShop.BusinessLogic.Abstractions;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserModel), 200)]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            
            var response = await _authService.Authenticate(request);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
