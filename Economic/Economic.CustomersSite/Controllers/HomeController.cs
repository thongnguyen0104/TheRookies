using Economic.CustomersSite.Integration;
using Economic.CustomersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Diagnostics;

namespace Economic.CustomersSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductApi _productApi;
        private HomeViewModels _homeViewModels;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productApi = RestService.For<IProductApi>("https://localhost:7246");
            _homeViewModels = new HomeViewModels();
        }

        public async Task<IActionResult> Index()
        {
            var products = _productApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModels.Products = products;
            return View(_homeViewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}