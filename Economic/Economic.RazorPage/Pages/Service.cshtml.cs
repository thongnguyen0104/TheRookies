using Economic.RazorPage.Integration;
using Economic.RazorPage.Models;
using Economic.ViewModels.Request.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace Economic.RazorPage.Pages
{
    public class ServiceModel : PageModel
    {

        private IProductApi _productApi;

        public HomeViewModels _homeViewModels;

        public CommentCreateRequest _request;
        [FromForm]
        public string contentCmt { set; get; }
        [FromForm]
        public int starCmt { set; get; }

        public ServiceModel()
        {
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
            //_request = new CommentCreateRequest();
        }
        //public async Task<IActionResult> OnPostAsync(int id, CommentCreateRequest request)
        //{
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            //var x = Request.RouteValues["id"];
            //if (Request.RouteValues["id"] != null)
            //{
            //var id = int.Parse(Request.RouteValues["id"].ToString());

            //var product = _productApi.GetByIdAsync(id).GetAwaiter().GetResult();

            //var sameProducts = _productApi.GetByIdProductTypeAsync(product.ProductTypeId).GetAwaiter().GetResult();

            //var comments = _productApi.GetByIdProductAsync(id).GetAwaiter().GetResult();

            ////if (comments != null)
            ////{
            //_homeViewModels.Comments = comments;
            ////}

            //_homeViewModels.Product = product;
            //_homeViewModels.SameProducts = sameProducts;


            ////ViewData["data"] = "dgfg";
            ////ViewData["sao"] = 5;
            ////ViewData["id"] = id;

            ////  string rid = Request.Form["contentRequest"];
            ////_request.Star = 5;
            //var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");
            //request.ProductId = id;
            //request.UserId = customerId2;

            //_productApi.CreateAsync(request, id).GetAwaiter().GetResult();

            ////}
            //return Redirect("Index");
        //}
    }

}
