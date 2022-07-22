using AutoMapper;
using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Economic.ViewModels.Request.Comment;
using Economic.ViewModels.Request.Product;
using Economic.ViewModels.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductsController(IProductService productService, ICommentService commentService, IMapper mapper, IWebHostEnvironment hostEnvironment)
        {
            _productService = productService;
            _commentService = commentService;
            _mapper = mapper;
            _hostEnvironment = hostEnvironment;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllAsync();
            products.ForEach(x => x.ProductImages.ForEach(p => p.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, p.ProductPath)));
            return Ok(products);
        }

        [HttpGet("{id}")]
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
                product.ProductImages.ForEach(x => x.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ProductPath));
                return Ok(product);
            } 
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("productType/{id}")]
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
                products.ForEach(x => x.ProductImages.ForEach(p => p.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, p.ProductPath)));
                return Ok(products);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Search/{keyWord}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByKeyword([FromRoute]string keyWord)
        {
            try
            {
                var product = await _productService.GetByKeywordAsync(keyWord);
                if (product == null)
                {
                    return NotFound($"Cannot find a product with keyWord: {keyWord}");
                }
                product.ForEach(x => x.ProductImages.ForEach(p => p.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, p.ProductPath)));
                return Ok(product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("delete/{id}")]
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
            result.ProductImages.ForEach(x => x.ProductPath = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ProductPath));
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

        [HttpGet("{productId}/comments")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByIdProduct(int productId)
        {
            try
            {
                var comments = await _commentService.GetByIdProductAsync(productId);
                if (comments == null)
                {
                    return NotFound($"Cannot find a comment  with Id product: {productId}");
                }
                return Ok(comments);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("{id}/comments")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateComment([FromBody] CommentCreateRequest request,[FromRoute] int id)
        {
            try
            {
                var commentId = await _commentService.CreateAsync(request, id);
                if (commentId == 0)
                {
                    return BadRequest();
                }
                return Ok(commentId);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}