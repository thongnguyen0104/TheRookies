using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Economic.ViewModels.Request.ProductType;
using Economic.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IConfiguration _configuration;
        private readonly EconomicDbContext _context;

        private const int DEFAULT_LIMIT = 999;
        private const int DEFAULT_PAGE_INDEX = 1;

        public ProductTypeService(EconomicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<int> CreateAsync(ProductTypeCreateRequest request)
        {
            var productType = new ProductType()
            {
                Name = request.Name,
                Description = request.Description,
            };
            await _context.AddAsync(productType);
            await _context.SaveChangesAsync();

            return productType.Id;
        }

        public async Task<int> DeleteAsync(int productTypeId)
        {
            var productType = await _context.ProductTypes.Where(x => x.Id == productTypeId).FirstOrDefaultAsync();

            if (productType == null)
            {
                throw new EconomicException($"Cannot delete product with Id: {productTypeId}");
            }

            _context.ProductTypes.Remove(productType);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductTypeViewModel>> GetAllAsync()
        {
            return await _context.ProductTypes.Select(productType => new ProductTypeViewModel()
            {
                Id = productType.Id,
                Name = productType.Name,
                Description = productType.Description,
            }).ToListAsync();
        }

        public async Task<ProductTypeViewModel> GetByIdAsync(int productTypeId)
        {
            var _productType = await _context.ProductTypes.Where(p => p.Id == productTypeId).FirstOrDefaultAsync();

            if (_productType == null)
            {
                throw new EconomicException($"Cannot find product type with Id = {productTypeId}");
            }
            var result = new ProductTypeViewModel()
            {
                Id = _productType.Id,
                Name = _productType.Name,
                Description = _productType.Description,
            };
            return result;
        }

        public async Task<int> UpdateAsync(ProductTypeUpdateRequest request)
        {
            var productType = await _context.ProductTypes.FindAsync(request.Id);
            if (productType == null)
            {
                throw new EconomicException($"Cannot find product type with Id: {request.Id}");
            }
            productType.Name = request.Name;
            productType.Description = request.Description;

            return await _context.SaveChangesAsync();
        }
    }
}
