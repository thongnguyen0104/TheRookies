using Economic.ViewModels.Request.ProductImage;
using Economic.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Interface
{
    public interface IProductImageService
    {
        Task<int> CreateAsync(ProductImageCreateRequest request);
        Task<int> UpdateAsync(ProductImageCreateRequest request, int productId);
        Task<int> DeleteAsync(int productImageId, int productId);
        Task<List<ProductImageViewModel>> GetByProductIdAsync(int productId);
        Task<ProductImageViewModel> GetByIdAsync(int productImageId, int productId);
    }
}
