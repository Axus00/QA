using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.App.Controllers.Users
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _service;
        public UsersController(IUserRepository service)
        {
            _service = service;
        }

        //Endpoint
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _service.GetUsers();
            return Ok(users);
        }
    }
}