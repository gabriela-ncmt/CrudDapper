using CrudDapper.Dto;
using CrudDapper.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInterface _userInterface;
        public UserController(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userInterface.GetUsers();
            
            if(users.Status == false)
                return NotFound(users);

            return Ok(users);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var user = await _userInterface.GetUserById(userId);
            if(user.Status == false)
                return NotFound(user);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            var users = await _userInterface.CreateUser(createUserDto);

            if(users.Status == false)
                BadRequest(users);

            return Ok(users);
        }

        [HttpPut]
        public async Task<IActionResult> EditUser(EditUserDto editUserDto)
        {
            var users = await _userInterface.EditUser(editUserDto);

            if (users.Status == false)
                BadRequest(users);

            return Ok(users);
        }
    }
}
