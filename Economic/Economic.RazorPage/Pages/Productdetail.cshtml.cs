using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace Economic.RazorPage.Pages
{
    public class ProductdetailModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IProductApi _productApi;
        private IProductTypeApi _productTypeApi;

        public HomeViewModels _homeViewModels;


        public ProductdetailModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _productTypeApi = RestService.For<IProductTypeApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
        }

        public async Task<IActionResult> OnGetAsync(int? idd)
        {
            int id = int.Parse(Request.RouteValues["idd"].ToString());

            var product = _productApi.GetByIdAsync(id).GetAwaiter().GetResult();

            _homeViewModels.Product = product;

            return Page();
        }
    }
}
