using Economic.Data.EF;
using Economic.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly EconomicDbContext _context;
        public ProductsController(EconomicDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _context.Products.FirstOrDefault(product => product.Id == id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }
}