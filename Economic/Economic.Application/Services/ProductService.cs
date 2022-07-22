using AutoMapper;
using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
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
using Unipluss.Sign.ExternalContract.Entities;

namespace Economic.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly EconomicDbContext _context;
        //private readonly ProductImageViewModel _productImageViewModel;

        //private const int DEFAULT_LIMIT = 999;
        //private const int DEFAULT_PAGE_INDEX = 1;

        public ProductService(EconomicDbContext context, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
            //_productImageViewModel = productImageViewModel;
        }
        public async Task<int> CreateAsync(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                ProductTypeId = request.ProductTypeId,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }
        public async Task<int> DeleteAsync(int productId)
        {
            var product = await _context.Products.Where(x => x.Id == productId).Include(x => x.ProductImages).FirstOrDefaultAsync();

            if (product == null)
            {
                throw new EconomicException($"Cannot delete product with Id: {productId}");
            }

            //_context.Products.Remove(product);
            product.IsDeleted = 1;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if(product == null)
            {
                throw new EconomicException($"Cannot find product with Id: {request.Id}");
            }
            product.Name = request.Name;
            product.Price = request.Price;
            product.Description = request.Description;
            product.ProductTypeId = request.ProductTypeId;
            product.UpdatedDate = DateTime.Now;
            //product.UpdatedDate = request.UpdatedDate;
            product.IsDeleted = 0;

            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<List<ProductViewModel>> GetAllAsync()
        {
            return await _context.Products.Where(x => x.IsDeleted == 0)
                .Include(x => x.ProductType)
                .Include(x => x.ProductImages)
                .Select(product => new ProductViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    CreatedDate = (DateTime)product.CreatedDate,
                    UpdatedDate = product.UpdatedDate,
                    ProductTypeId = product.ProductTypeId,
                    ProductTypeName = product.ProductType.Name,
                    IsDeleted = product.IsDeleted,
                    ProductImages =_context.ProductImages.Where(pM => pM.ProductId == product.Id).Select(image => new ProductImageViewModel()
                    {
                        Id = image.Id,
                        ProductId = image.ProductId,
                        ProductPath = image.ProductPath,
                    }).ToList()
                    //Comments = _mapper.Map<List<CommentViewModel>>(product.Comments)
                }).ToListAsync();

            //return await _context.Products.Select(product => _mapper.Map<ProductViewModel>(product)).ToListAsync();
        }
        public async Task<ProductViewModel> GetByIdAsync(int productId)
        {
            var product = await _context.Products.Where(x => (x.Id == productId) && (x.IsDeleted == 0))
                .Include(x =>x.ProductType)
                .Include(x => x.ProductImages)
                .FirstOrDefaultAsync();
            if (product == null)
            {
                throw new EconomicException($"Cannot find product with Id = {productId}");
            }
            var result = new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                ProductTypeId = product.ProductTypeId,
                ProductTypeName = product.ProductType.Name,
                IsDeleted = product.IsDeleted,
                ProductImages = product.ProductImages == null ? null : _context.ProductImages.Where(pM => pM.ProductId == product.Id).Select(image => new ProductImageViewModel()
                {
                    Id = image.Id,
                    ProductId = image.ProductId,
                    ProductPath = image.ProductPath,
                }).ToList()
            };
            return result;
        }
        public async Task<List<ProductViewModel>> GetByKeywordAsync(string keyWord)
        {
            var product = await _context.Products.Where(x => (x.Name.Contains(keyWord)) && (x.IsDeleted == 0))
                .Include(x => x.ProductImages)
                .Select(product => new ProductViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    CreatedDate = product.CreatedDate,
                    UpdatedDate = product.UpdatedDate,
                    ProductTypeId = product.ProductTypeId,
                    ProductImages = _context.ProductImages.Where(pM => pM.ProductId == product.Id).Select(image => new ProductImageViewModel()
                    {
                        Id = image.Id,
                        ProductId = image.ProductId,
                        ProductPath = image.ProductPath,
                    }).ToList()
                }).ToListAsync();

            if (product == null)
            {
                throw new EconomicException($"Cannot find product with keyword = {keyWord}");
            }
            return product;

        }
        public async Task<List<ProductViewModel>> GetByIdProductTypeAsync(int productTypeId)
        {
            var products = await _context.Products.Where(x => (x.ProductTypeId == productTypeId) && (x.IsDeleted == 0))
                .Include(x => x.ProductImages)
                .Select(product => new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                ProductTypeId = product.ProductTypeId,
                ProductImages = _context.ProductImages.Where(pM => pM.ProductId == product.Id).Select(image => new ProductImageViewModel()
                {
                    Id = image.Id,
                    ProductId = image.ProductId,
                    ProductPath = image.ProductPath,
                }).ToList()
            }).ToListAsync();

            if (products == null)
            {
                throw new EconomicException($"Cannot find product with productTypeId = {productTypeId}");
            }
            return products;
        }
    }
}
