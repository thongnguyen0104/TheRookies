using Economic.ViewModels.Catalog.Products;
using Economic.ViewModels.Catalog.Products.Public;
using Economic.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByProductTypeId(GetProductPagingRequest request);
    }
}
