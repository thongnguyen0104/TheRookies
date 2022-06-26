using Economic.Application.Catalog.Products.Dtos;
using Economic.Application.Catalog.Products.Dtos.Manage;
using Economic.Application.Dtos;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Catalog.Products
{
    public class ManageProductService : IManagedProductService
    {
        private readonly EconomicDbContext _context;

        public ManageProductService(EconomicDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null) throw new EconomicException($"Cannot find a product: {productId}");

            _context.Products.Remove(product);
            return await (_context.SaveChangesAsync());

        }

        //public Task<List<ProductViewModel>> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            // 1. Select join
            var query = from p in _context.Products
                        join pt in _context.ProductTypes on p.ProductTypeId equals pt.Id
                        select new { p, pt};
            //2. Filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.p.Name.Contains(request.Keyword));

            if (request.ProductTypeIds.Count > 0)
            {
                query = query.Where(p => request.ProductTypeIds.Contains(p.p.ProductTypeId));
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    Price = x.p.Price,
                    Description = x.p.Description,
                }
                ).ToListAsync();

            //4. Select and projection
            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;

        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }
    }
}
