using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Economic.ViewModels.Request.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace Economic.RazorPage.Pages
{
    public class ProductdetailModel : PageModel
    {
        private readonly ILogger<ProductdetailModel> _logger;
        private IProductApi _productApi;

        public HomeViewModels _homeViewModels;

        public CommentCreateRequest _request;

        public ProductdetailModel(ILogger<ProductdetailModel> logger)
        {
            _logger = logger;
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
            _request = new CommentCreateRequest();
        }

        public async Task<IActionResult> OnGet()
        {
            if (Request.RouteValues["id"] != null)
            {
                int id = int.Parse(Request.RouteValues["id"].ToString());
                var product = _productApi.GetByIdAsync(id).GetAwaiter().GetResult();
                var comments = _productApi.GetByIdProductAsync(id).GetAwaiter().GetResult();
                var sameProducts = _productApi.GetByIdProductTypeAsync(product.ProductTypeId).GetAwaiter().GetResult();
                if (comments != null)
                {
                    _homeViewModels.Comments = comments;
                }
                _homeViewModels.Product = product;
                _homeViewModels.SameProducts = sameProducts;
            }
            else
            {
                RedirectToPage("Index");
            }
            return Page();
        }
    
        public async Task<IActionResult> OnPostAsync(int id, CommentCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var product = _productApi.GetByIdAsync(id).GetAwaiter().GetResult();
                var sameProducts = _productApi.GetByIdProductTypeAsync(product.ProductTypeId).GetAwaiter().GetResult();
                var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");
                request.ProductId = id;
                request.UserId = customerId2;
                var result = _productApi.CreateAsync(request, id).GetAwaiter().GetResult();
                if (result == 0)
                {
                    return RedirectToPage("Index");
                }
                var comments = _productApi.GetByIdProductAsync(id).GetAwaiter().GetResult();
                if (comments != null)
                {
                    _homeViewModels.Comments = comments;
                }
                
                _homeViewModels.Product = product;
                _homeViewModels.SameProducts = sameProducts;
            }

            return Page();
            //string url = "product/" + id;
            //return base.Redirect(url);
        }

    }
}
