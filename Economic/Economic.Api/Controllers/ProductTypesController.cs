using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.ViewModels.Request.ProductType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProductTypesController : ControllerBase
    {
        private readonly EconomicDbContext _context;
        private readonly IProductTypeService _productTypeService;
        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            try
            {
                var productTypes = await _productTypeService.GetAllAsync();
                return Ok(productTypes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var productType = await _productTypeService.GetByIdAsync(id);
                //if (productType == null)
                //{
                //    return NotFound($"Cannot find a product type with Id: {id}");
                //}
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
                if (productType == 0)
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
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var productTypeId = await _productTypeService.CreateAsync(request);
                
                if (productTypeId == 0)
                {
                    return BadRequest();
                }

                var result = await _productTypeService.GetByIdAsync(productTypeId);
                if(result == null)
                {
                    return NotFound($"Cannot find a product with Id: {productTypeId}");
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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

                var data = await _productTypeService.GetByIdAsync(request.Id);
                if (data == null)
                {
                    return NotFound($"Cannot find a product with Id: {request.Id}");
                }
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}