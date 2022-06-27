using Economic.Application.Common;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Economic.ViewModels.Catalog.Products;
using Economic.ViewModels.Catalog.Products.Public;
using Economic.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Catalog.Products
{
    public class ManageProductService : IManagedProductService
    {
        private readonly EconomicDbContext _context;
        private readonly IStorageService _storageService;

        public ManageProductService(EconomicDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public Task<int> AddImages(int productId, List<IFormFile> files)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(ViewModels.Catalog.Products.Manage.ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                ProductTypeId = 1,
            };
            // Save image
            if(request.ThumbnailPath != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        ProductPath = await this.SaveFile(request.ThumbnailPath),
                    }
                };
            }

            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null) throw new EconomicException($"Cannot find a product: {productId}");

            var images = _context.ProductImages.Where(i => i.ProductId == productId);
            
            foreach(var image in images)
            {
                await _storageService.DeleteFileAsync(image.ProductPath);
            }

            _context.Products.Remove(product);
            
            return await (_context.SaveChangesAsync());
        }
        //public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        //{
        //    // 1. Select join
        //    var query = from p in _context.Products
        //                join pt in _context.ProductTypes on p.ProductTypeIds equals pt.Id
        //                select new { p, pt};
        //    //2. Filter
        //    if (!string.IsNullOrEmpty(request.Keyword))
        //        query = query.Where(x => x.p.Name.Contains(request.Keyword));

        //    if (request.ProductTypeId.Count > 0)
        //    {
        //        query = query.Where(p => request.ProductTypeId.Contains(p.p.ProductTypeIds));
        //    }
        //    //3. Paging
        //    int totalRow = await query.CountAsync();

        //    var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
        //        .Take(request.PageSize)
        //        .Select(x => new ProductViewModel()
        //        {
        //            Id = x.p.Id,
        //            Name = x.p.Name,
        //            Price = x.p.Price,
        //            Description = x.p.Description,
        //        }
        //        ).ToListAsync();

        //    //4. Select and projection
        //    var pageResult = new PagedResult<ProductViewModel>()
        //    {
        //        TotalRecord = totalRow,
        //        Items = data,
        //    };
        //    return pageResult;

        //}

        public Task<PagedResult<ProductViewModel>> GetAllPaging(ViewModels.Catalog.Products.Manage.GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<ViewModels.Catalog.Products.Public.ProductImageViewModel>> GetListImage(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<int> RomoveImages(int imageId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ViewModels.Catalog.Products.Manage.ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null) throw new EconomicException($"Cannot find a product with id: {request.Id}");

            product.Name = request.Name;
            product.Description = request.Description;

            // Save image
            if (request.ThumbnailPath != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.ProductPath = await this.SaveFile(request.ThumbnailPath);
                    _context.ProductImages.Update(thumbnailImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EconomicException($"Cannot find a product with id: {productId}");

            product.Price = newPrice;

            return await _context.SaveChangesAsync() > 0;
        }


        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
