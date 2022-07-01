using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Economic.ViewModels.Request.Product;
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

        [HttpGet("productTypeId")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByIdProductType(int id)
        {
            try
            {
                var products = await _productService.GetByIdProductTypeAsync(id);
                if (products == null)
                {
                    return NotFound($"Cannot find a product with Id: {id}");
                }
                return Ok(products);
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
                if (product > 0)
                {
                    return Ok(product);
                    
                }
                return NotFound($"Cannot Delete a product with Id: {id}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Create([FromBody]ProductCreateRequest request)
        {
            var productId = await _productService.CreateAsync(request);
            if(productId == null)
            {
                return BadRequest();
            }
            var result = await _productService.GetByIdAsync(productId);
            if(result == null)
            {
                return NotFound($"Cannot find a product with Id: {productId}");
            }
            return Ok(result);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _productService.UpdateAsync(request);
                if(result == 0)
                {
                    return BadRequest();
                }
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}