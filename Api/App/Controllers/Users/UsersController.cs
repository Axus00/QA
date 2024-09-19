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
        private string Error = "The request has no been resolved";
        public UsersController(IUserRepository service)
        {
            _service = service;
        }

        //Endpoint
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(Utils.Exceptions.StatusError.CreateBadRequest());
            }

            try
            {
                
            }
            catch (Exception)
            {
                throw new Exception(Error);
            }

            var users = await _service.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(Utils.Exceptions.StatusError.CreateBadRequest());
            }

            try
            {
                var userById = await _service.GetUserById(id);
                return Ok(userById);
            }
            catch (Exception)
            {
                throw new Exception(Error);
            }
        }
    }
}