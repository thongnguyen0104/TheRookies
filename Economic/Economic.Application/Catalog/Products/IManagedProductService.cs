using Economic.ViewModels.Catalog.Products;
using Economic.ViewModels.Catalog.Products.Manage;
using Economic.ViewModels.Catalog.Products.Public;
using Economic.ViewModels.Common;
using Microsoft.AspNetCore.Http;

namespace Economic.Application.Catalog.Products
{
    public interface IManagedProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<PagedResult<ProductViewModel>> GetAllPaging(ViewModels.Catalog.Products.Manage.GetProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RomoveImages(int imageId);
        //Task<int> UpdateImage(int imageId);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
