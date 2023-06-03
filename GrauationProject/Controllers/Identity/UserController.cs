using GraduationProject.Domain.ViewModels.Identity;
using GraduationProject.Services.IServices.UserServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Api.Controllers.Identity
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
        public async Task<IActionResult> AddUserAsync(AddUserRequest model, [FromForm] IFormFile? image)
        {
           var data =await _userService.AddUserAsync(model,image);
            if (!data.IsSuccess==true)
                return StatusCode(500, data.Message);

            return Ok(data);
        }

        [HttpPut("UploadPhoto")]
        public async Task<IActionResult> UploadPhoto([FromForm]string email,[FromForm] IFormFile image)
        {
            var data = await _userService.UploadPhoto(image, email);
            if (!data.IsSuccess == true)
                return StatusCode(500, data.Message);

            return Ok(data);
        }
    }
}
