using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Economic.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;
using System.Collections.Generic;

namespace Economic.RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IProductApi _productApi;
        private IProductTypeApi _productTypeApi;

        public HomeViewModels _homeViewModels;

        public string thongbao = "Day la thong bao";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _productTypeApi = RestService.For<IProductTypeApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var products = _productApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModels.Products = products;

            var productTypes = _productTypeApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModels.ProductTypes = productTypes;

            return Page();
        }

    }
}