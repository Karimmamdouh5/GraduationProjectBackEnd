using GraduationProject.Services.IServices.ComputersServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Api.Controllers.Computers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private readonly IComputersService _computersService;
        public ComputersController(IComputersService computersService)
        {
            _computersService = computersService;
        }

        [HttpGet("GetAllComputers")]
        public async Task<IActionResult> GetAllComputers()
        {
            var data = await _computersService.GetAllComputers();
            if (data.IsSuccess == true)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500, data.Message);
            }
        }

        [HttpGet("GetAllCompPurposes")]

        public async Task<IActionResult> GetAllCompPurposes()
        {
            var data = await _computersService.GetAllCompPurposes();
            if (data.IsSuccess)
            {
                return Ok(data);
            }
            return StatusCode(500, data.Message);
        }
    }
}
