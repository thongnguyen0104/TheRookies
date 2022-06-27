using Economic.Data.EF;
using Economic.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Economic.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductTypesController : ControllerBase
    {
        private readonly EconomicDbContext _context;
        public ProductTypesController(EconomicDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var productTypes = _context.ProductTypes.ToList();
            return Ok(productTypes);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var productTypes = _context.ProductTypes.FirstOrDefault(productTypes => productTypes.Id == id);
            return Ok(productTypes);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            await _context.SaveChangesAsync();
            return Ok(productType);
        }
    }
}