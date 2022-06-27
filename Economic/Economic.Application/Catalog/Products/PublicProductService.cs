using Economic.Data.EF;
using Economic.ViewModels.Catalog.Products;
using Economic.ViewModels.Catalog.Products.Public;
using Economic.ViewModels.Common;
using Microsoft.EntityFrameworkCore;

namespace Economic.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly EconomicDbContext _context;

        public PublicProductService(EconomicDbContext context)
        {
            _context = context;
        }

        public Task<PagedResult<ProductViewModel>> GetAllByProductTypeId(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
        //public async Task<PagedResult<ProductViewModel>> GetAllByProductTypeId(GetProductPagingRequest request)
        //{
        //    // 1. Select join
        //    var query = from p in _context.Products
        //                join pt in _context.ProductTypes on p.ProductTypeIds equals pt.Id
        //                select new { p, pt };
        //    //2. Filter
        //    if (request.ProductTypeId.HasValue && request.ProductTypeId.Value > 0)
        //    {
        //        query = query.Where(p => p.pt.Id == request.ProductTypeId);
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
    }
}
