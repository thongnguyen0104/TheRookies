using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace Economic.RazorPage.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ILogger<SearchModel> _logger;
        private IProductApi _productApi;
        public HomeViewModels _homeViewModels;
        public SearchModel(ILogger<SearchModel> logger)
        {
            _logger = logger;
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
        }
        public async Task<IActionResult> OnGetAsync(string keyWord)
        { 
            if (!string.IsNullOrEmpty(keyWord))
            {

                var products = _productApi.GetByKeywordAsync(keyWord).GetAwaiter().GetResult();
                _homeViewModels.Products = products;
                _homeViewModels.keyword = keyWord;

                return Page();
                //return Page();
            }
            return RedirectToPage("Index");
        }
    }
}
