using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuantDeveloper.Business;
using QuantDeveloper.Business.Interfaces;
using Newtonsoft.Json;
using QuantDeveloper.Data.Interfaces;
using QuantDeveloper.Business.Models;

namespace QuantDeveloper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomExceptionFilter]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _userService;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IUsersRepository _userRepository;

        public UsersController(IRepositoryFactory repositoryFactory, IUsersService userRepository)
        {
            _repositoryFactory = repositoryFactory;
            _userService = userRepository;
        }

        // GET api/users
        [HttpGet]
        public ActionResult All()
        {
            var users = _userService.FindAll();
            if (users != null && users.Any())
            {
                return new JsonResult(users);
            }
            return new JsonResult("No Users found");
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = _userService.GetUserByUserId(id);
            if (user != null)
            {
                return new JsonResult(user);
            }
            return new JsonResult("User Not Found");
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] User user)
        {
            if (user != null) { 
                _userService.Create(user);
            }
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] User user)
        {
            if (_userService.GetUserByUserId(id) != null) { 
                _userService.Update(user);
            }
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_userService.GetUserByUserId(id) != null)
            {
                _userService.Delete(_userService.GetUserByUserId(id));
            }
        }
    }
}