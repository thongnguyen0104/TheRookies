using Economic.ViewModels.ViewModels;
using Refit;

namespace Economic.CustomersSite.Integration
{
    public interface IProductApi
    {
        [Get("/api/Products")]
        Task<List<ProductViewModel>> GetAllAsync();
    }
}
