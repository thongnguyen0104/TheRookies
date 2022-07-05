using Economic.ViewModels.ViewModels;
using Refit;

namespace Economic.RazorPage.Integration
{
    public interface IProductTypeApi
    {
        [Get("/api/ProductTypes")]
        Task<List<ProductTypeViewModel>> GetAllAsync();
    }
}
