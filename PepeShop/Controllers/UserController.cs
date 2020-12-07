using Microsoft.AspNetCore.Mvc;
using PepeShop.BusinessLogic.Abstractions;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserListItem>> GetUsers()
        {
            var result = await _userService.GetUserList();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<UserModel> GetUser(int id)
        {
            var result = await _userService.GetUser(id);
            return result;

        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] UserModel user)
        {
            await _userService.AddUser(user);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditUser([FromBody] UserModel user)
        {
            await _userService.EditUser(user);
            return Ok();
        }
    }
}
