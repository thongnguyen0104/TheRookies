using Economic.ViewModels.Request.Comment;
using Economic.ViewModels.ViewModels;
using Refit;

namespace Economic.RazorPage.Integration
{
    public interface IProductApi
    {
        [Get("/api/Products")]
        Task<List<ProductViewModel>> GetAllAsync();

        [Get("/api/Products/{id}")]
        Task<ProductViewModel> GetByIdAsync(int id);

        [Get("/api/Products/productType/{id}")]
        Task<List<ProductViewModel>> GetByIdProductTypeAsync(int id);

        [Get("/api/Products/Search/{keyWord}")]
        Task<List<ProductViewModel>> GetByKeywordAsync(string keyWord);

        [Get("/api/Products/{id}/comments")]
        Task<List<CommentViewModel>> GetByIdProductAsync(int id);

        [Post("/api/Products/{id}/comments")]
        Task<int> CreateAsync(CommentCreateRequest request, int id);
    }
}
