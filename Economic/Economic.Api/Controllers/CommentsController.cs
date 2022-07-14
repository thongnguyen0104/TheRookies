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

namespace Economic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly EconomicDbContext _context;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentsController(EconomicDbContext context, ICommentService commentService, IMapper mapper)
        {
            _context = context;
            _commentService = commentService;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByIdProduct(int id)
        {
            try
            {
                var comments = await _commentService.GetByIdProductAsync(id);
                if (comments == null)
                {
                    return NotFound($"Cannot find a comment  with Id product: {id}");
                }
                return Ok(comments);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}
