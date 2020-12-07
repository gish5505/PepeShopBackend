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
        public async Task<UserModel> Authenticate([FromBody] LoginRequest request)
        {
            
            var result = await _authService.Authenticate(request);

            return result;
        }
    }
}
