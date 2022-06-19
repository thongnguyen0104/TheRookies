using Microsoft.AspNetCore.Mvc;

namespace Economi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public class Products
        {
            public int Id { set; get; }
            public string Name { set; get; }
            public int Price { set; get; }
        }

        public List<Products> Products()
         {
            Id = 1,
            Name = "Nồi cơm điện",
            Price = 199000
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
    }
}