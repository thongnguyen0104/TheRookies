using AutoMapper;
using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Utilities.Exceptions;
using Economic.ViewModels.Request.Product;
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
    public class ProductService : IProductService
    {
        //private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly EconomicDbContext _context;

        private const int DEFAULT_LIMIT = 999;
        private const int DEFAULT_PAGE_INDEX = 1;

        public ProductService(EconomicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public Task<int> CreateAsync(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }
        public async Task<int> DeleteAsync(int productId)
        {
            var product = await _context.Products.Where(x => x.Id == productId).Include(x => x.ProductImages).FirstOrDefaultAsync();

            if (product == null)
            {
                throw new EconomicException($"Cannot find cake with Id: {productId}");
            }

            //foreach (var image in product.ProductImages.ToList())
            //{
            //    await _productImageService.DeleteAsync(image.Id, productId);
            //}

            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
        }


        public Task<int> UpdateAsync(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAllAsync()
        {
            return await _context.Products.Select(product => new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = (DateTime)product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                ProductTypeId = product.ProductTypeId,
            }).ToListAsync();

            //return await _context.Products.Select(product => _mapper.Map<ProductViewModel>(product)).ToListAsync();
        }


        public async Task<ProductViewModel> GetByIdAsync(int productId)
        {
            var _product = await _context.Products.Where(x => x.Id == productId).FirstOrDefaultAsync();
            if (_product == null)
            {
                throw new EconomicException($"Cannot find product with Id = {productId}");
            }
            var result = new ProductViewModel()
            {
                Id = _product.Id,
                Name = _product.Name,
                Price = _product.Price,
                Description = _product.Description,
                CreatedDate = _product.CreatedDate,
                UpdatedDate = _product.UpdatedDate,
                ProductTypeId = _product.ProductTypeId,
            };
            return result;
        }
        public async Task<List<ProductViewModel>> GetByKeywordAsync(string keyWord)
        {
            var product = await _context.Products.Where(x => x.Name.Contains(keyWord)).Select(product => new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                ProductTypeId = product.ProductTypeId,
            }).ToListAsync();

            if (product == null)
            {
                throw new EconomicException($"Cannot find product with keyword = {keyWord}");
            }
            return product;

        }
    }
}
