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
    }
}
