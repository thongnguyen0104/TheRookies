using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace Economic.RazorPage.Pages
{
    public class ProducttypesModel : PageModel
    {
        private readonly ILogger<ProducttypesModel> _logger;
        private IProductApi _productApi;
        private IProductTypeApi _productTypeApi;

        public HomeViewModels _homeViewModels;

        public string thongbao = "Day la thong bao";

        public ProducttypesModel(ILogger<ProducttypesModel> logger)
        {
            _logger = logger;
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _productTypeApi = RestService.For<IProductTypeApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            //var products = _productApi.GetAllAsync().GetAwaiter().GetResult();
            //_homeViewModels.Products = products;

            var productTypes = _productTypeApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModels.ProductTypes = productTypes;

            var sameProducts = _productApi.GetByIdProductTypeAsync(id).GetAwaiter().GetResult();
            _homeViewModels.SameProducts = sameProducts;

            return Page();
        }

        //public async Task<IActionResult> OnGetAsync(int ptId)
        //{
        //    //var products = _productApi.GetAllAsync().GetAwaiter().GetResult();
        //    //_homeViewModels.Products = products;

        //    var productTypes = _productTypeApi.GetAllAsync().GetAwaiter().GetResult();
        //    _homeViewModels.ProductTypes = productTypes;

        //    var sameProducts = _productApi.GetByIdProductTypeAsync(ptId).GetAwaiter().GetResult();
        //    _homeViewModels.SameProducts = sameProducts;

        //    return Page();
        //}
    }
}
