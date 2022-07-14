using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.ViewModels.Request.ProductType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProductTypesController : ControllerBase
    {
        private readonly EconomicDbContext _context;
        private readonly IProductTypeService _productTypeService;
        public ProductTypesController(EconomicDbContext context, IProductTypeService productTypeService)
        {
            _context = context;
            _productTypeService = productTypeService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var productTypes = await _productTypeService.GetAllAsync();
            return Ok(productTypes);
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var productType = await _productTypeService.GetByIdAsync(id);
                if (productType == null)
                {
                    return NotFound($"Cannot find a product type with Id: {id}");
                }
                return Ok(productType);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var productType = await _productTypeService.DeleteAsync(id);
                if (productType == null)
                {
                    return NotFound($"Cannot Delete a product type with Id: {id}");
                }
                return Ok(productType);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] ProductTypeCreateRequest request)
        {
            var productTypeId = await _productTypeService.CreateAsync(request);
            if (productTypeId == null)
            {
                return BadRequest();
            }
            var result = await _productTypeService.GetByIdAsync(productTypeId);
            if (result == null)
            {
                return NotFound($"Cannot find a product type with Id: {productTypeId}");
            }
            return Ok(result);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] ProductTypeUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _productTypeService.UpdateAsync(request);
                if (result == 0)
                {
                    return BadRequest();
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}