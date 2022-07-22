using AutoMapper;
using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Economic.ViewModels.Request.ProductImage;
using Economic.ViewModels.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Economic.Application.Services
{
    public class ProductImageService : IProductImageService
    {
        private readonly EconomicDbContext _context;
        private readonly IStorageService _storageService;
        public ProductImageService(EconomicDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> CreateAsync(ProductImageCreateRequest request)
        {
            var product = await _context.Products.FindAsync(request.ProductId);
            if (product == null)
            {
                throw new EconomicException($"Cannot find product with Id: {request.ProductId}");
            }
            if (request.ImageFile != null)
            {
                var productImg = new ProductImage()
                {
                    ProductId = request.ProductId,
                    ProductPath = await SaveFileAsync(request.ImageFile)
                };
                await _context.AddAsync(productImg);
                await _context.SaveChangesAsync();
                return productImg.Id;
            }
            return -1;
        }

        public Task<int> DeleteAsync(int productImageId, int productId)
        {
            throw new NotImplementedException();
        }
        public async Task<ProductImageViewModel> GetByIdAsync(int productImageId, int productId = 0)
        {
            var image = await _context.ProductImages.Where(x => x.Id == productImageId).FirstOrDefaultAsync();
            
            if (image != null && productId != 0 && productId != image.ProductId)
            {
                return null;
            }
            var result = new ProductImageViewModel()
            {
                Id = image.Id,
                ProductId = image.ProductId,
                ProductPath = image.ProductPath,
            };

            return result;
        }
        public async Task<List<ProductImageViewModel>> GetByProductIdAsync(int productId)
        {
            var images = await _context.ProductImages.Where(x => x.ProductId == productId).Select(productImages => new ProductImageViewModel()
            {
                Id = productImages.Id,
                ProductId = productImages.ProductId,
                ProductPath = productImages.ProductPath,
            }).ToListAsync();

            if(images == null)
            {
                throw new EconomicException($"Cannot find product image with productId: {productId}");
            }
            return images;
        }

        public async Task<int> UpdateAsync(ProductImageUpdateRequest request, int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var productImg = await _context.ProductImages.FindAsync(request.Id);
            if (product == null)
            {
                throw new EconomicException($"Cannot find product with Id: {productId}");
            }

            if (productImg == null)
            {
                throw new EconomicException($"Cannot find product with Id: {request.Id}");
            }
            else if (productId != 0 && productId != productImg.ProductId)
            {
                throw new EconomicException($"Cannot find image product with Id: {request.Id} in product Id: {productId}");
            }
            if (request.ImageFile != null)
            {
                await _storageService.DeleteFileAsync(productImg.ProductPath);
                productImg.ProductPath = await SaveFileAsync(request.ImageFile);
            }

            return await _context.SaveChangesAsync();
        }

        private async Task<string> SaveFileAsync(IFormFile file)
        {
            if (file == null)
            {
                throw new EconomicException("Cannot add null file");
            }
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
