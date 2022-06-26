using Economic.Application.Catalog.Products.Dtos;
using Economic.Application.Catalog.Products.Dtos.Public;
using Economic.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByProductTypeId(GetProductPagingRequest request);
    }
}
