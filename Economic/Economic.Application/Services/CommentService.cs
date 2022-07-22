using AutoMapper;
using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.ViewModels.Request.Comment;
using Economic.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly EconomicDbContext _context;

        public CommentService(EconomicDbContext context, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
            //_productImageViewModel = productImageViewModel;
        }
        public async Task<int> CreateAsync(CommentCreateRequest request, int id)
        {
            var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");
            var comment = new Comment()
            {
                UserId = customerId2,
                ProductId = id,
                Star = request.Star,
                Content = request.Content,
                Created = DateTime.Now
            };
            await _context.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment.Id;
        }

        public async Task<List<CommentViewModel>> GetByIdProductAsync(int productId)
        {
            var comments = await _context.Comments.Where(cmt => cmt.ProductId == productId).Select(comment => new CommentViewModel()
            {
                Id = comment.Id,
                ProductId = comment.ProductId,
                UserName = comment.User.Name,
                Star = comment.Star,
                Content= comment.Content,
                CreatedDate = (DateTime)comment.Created,
            }).ToListAsync();

            return comments;
        }
    }
}
