using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Economic.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Economic.RazorPage.Pages.Shared.Components.ProductType
{
    public class ProductType : ViewComponent
    {
        private IProductTypeApi _productTypeApi;
        
        public ProductType()
        {
            _productTypeApi = RestService.For<IProductTypeApi>("https://localhost:7246");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productTypes = _productTypeApi.GetAllAsync().GetAwaiter().GetResult();

            return View<List<ProductTypeViewModel>>(productTypes);
        }
    }
}
