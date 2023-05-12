using GraduationProject.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrauationProject.Api.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService= productsService;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var data =await _productsService.GetAllProducts();
            if (data.IsSuccess==true)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500,data.Message);
            }
        }

        [HttpGet("ListOfCategories")]
        public async Task<IActionResult> ListOfCategories()
        {
            var data = await _productsService.ListOfCategories();
            if (data.IsSuccess == true)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500, data.Message);
            }
        }
    }
}
