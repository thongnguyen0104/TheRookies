using Economic.ViewModels.Request.Comment;
using Economic.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Interface
{
    public interface ICommentService
    {
        Task<int> CreateAsync(CommentCreateRequest request, int id);
        Task<List<CommentViewModel>> GetByIdProductAsync(int productId);
    }
}
