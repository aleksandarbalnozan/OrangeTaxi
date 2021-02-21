using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberWannBe.Data.Entity;
using UberWannBe.Dtos.User;
using UberWannBe.Services.Implementations;
using UberWannBe.Services.Interfaces;

namespace UberWannBe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;

        public UsersController(IUserRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        // api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var users = repository.GetAllUsers();
            return Ok(mapper.Map<IEnumerable<UserReadDto>>(users));
        }

        [HttpGet("{id}",Name = "GetUserById")]
        public ActionResult<UserReadDto> GetUserById(int id)
        {
            var user = repository.GetUser(id);
            if (user != null)
            {
                return Ok(mapper.Map<UserReadDto>(user));

            }
            return NotFound();
        }

        //POST api/users
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = mapper.Map<User>(userCreateDto);
            repository.CreateUser(userModel);
            var userReadDto = mapper.Map<UserReadDto>(userModel);
            return CreatedAtRoute(nameof(GetUserById), new { id = userModel.UserId}, userReadDto);
        }

        // PUT api/users/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserCreateDto userCreateDto)
        {
            var userModel = repository.GetUser(id);
            if (userModel ==null)
            {
                return NotFound();
            }
            mapper.Map(userCreateDto, userModel);
            repository.EditUser(id, userModel);
            return NoContent();
        }

        // DELETE api/users/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var userModel = repository.GetUser(id);
            if (userModel == null)
            {
                return NotFound();
            }
            repository.RemoveUser(id);
            return NoContent();
        }
    }
}
