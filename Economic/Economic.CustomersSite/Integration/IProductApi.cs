using Economic.ViewModels.ViewModels;
using Refit;

namespace Economic.CustomersSiteMVC.Integration
{
    public interface IProductApi
    {
        [Get("/api/Products")]
        Task<List<ProductViewModel>> GetAllAsync();
    }
}
