using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly EconomicDbContext _context;
        private readonly IProductService _productService;
        public ProductsController(EconomicDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                if(product == null)
                {
                    return NotFound($"Cannot find a product with Id: {id}");
                }
                return Ok(product);
            } 
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("KeyWord")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByKeyword(string Key)
        {
            try
            {
                var product = await _productService.GetByKeywordAsync(Key);
                if (product == null)
                {
                    return NotFound($"Cannot find a product with keyWord: {Key}");
                }
                return Ok(product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var product = await _productService.DeleteAsync(id);
                if (product == null)
                {
                    return NotFound($"Cannot Delete a product with Id: {id}");
                }
                return Ok(product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}