using GraduationProject.Domain.ViewModels.Identity;
using GraduationProject.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrauationProject.Api.Controllers.Identity
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;   
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUserAsync(AddUserRequest model)
        {
           var data =await _userService.AddUserAsync(model);
            if (!data.IsSuccess==true)
                return StatusCode(500, data.Message);

            return Ok(data);
        }
    }
}
