using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.ViewModels.Request.ProductImage;
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
        private readonly IWebHostEnvironment _hostEnvironment;
        public ImagesController(IProductImageService productImageService, IWebHostEnvironment hostEnvironment)
        {
            _productImageService = productImageService;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("productId")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByProductId(int productId)
        {
            try
            {
                var images = await _productImageService.GetByProductIdAsync(productId);
                if (images == null)
                {
                    return NotFound($"Cannot find a product image with Id: {productId}");
                }
                images.ForEach(x => x.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ProductPath));
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
                image.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, image.ProductPath);
                return Ok(image);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateAsync([FromForm] ProductImageCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var imageId = await _productImageService.CreateAsync(request);
                if (imageId == 0)
                {
                    return BadRequest();
                }
                var data = await _productImageService.GetByIdAsync(imageId, request.ProductId);
                if (data == null)
                {
                    return NotFound($"Cannot find image with Id: {imageId}");
                }
                data.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, data.ProductPath);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            //request.ProductPath = await SaveImage(request.ImageFile);
            //var ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, request.ProductPath);
            //request.ProductPath = ImageSrc;
            //var productImg = await _productImageService.CreateAsync(request);
            //return StatusCode(201);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateAsync([FromForm] ProductImageUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _productImageService.UpdateAsync(request, request.ProductId);
                //pass parameter productId = 0 to don't check product Id
                var data = await _productImageService.GetByIdAsync(request.Id, request.ProductId);
                if (data == null)
                {
                    return NotFound($"Cannot find image with Id: {request.Id}");
                }
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot/Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }

    }
}
