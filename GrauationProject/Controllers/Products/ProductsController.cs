using GraduationProject.Services.IServices.ProductsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Api.Controllers.Products
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

        [HttpPut("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int ProductId)
        {
            var result = await _productsService.DeleteProduct(ProductId);
            if (result.IsSuccess==true)
                return Ok(result.Message);
            return StatusCode(500, result.Message);
        }
    }
}
