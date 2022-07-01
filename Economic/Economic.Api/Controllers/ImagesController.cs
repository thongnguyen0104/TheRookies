using Economic.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;
        public ImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet("productId")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByProductId(int productId)
        {
            try
            {
                var images = await _productImageService.GetByProductIdAsync(productId);
                if(images == null)
                {
                    return NotFound($"Cannot find a product image with Id: {productId}");
                }
                return Ok(images);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{productImageId}/{producId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int productImageId, int producId)
        {
            try
            {
                var image = await _productImageService.GetByIdAsync(productImageId, producId);

                if (image == null)
                {
                    return NotFound($"Cannot find a product image with Id: {productImageId}");
                }
                return Ok(image);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
