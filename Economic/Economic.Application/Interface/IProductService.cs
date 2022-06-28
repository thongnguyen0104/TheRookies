using Economic.ViewModels.Request.Product;
using Economic.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Interface
{
    public interface IProductService
    {
        Task<int> CreateAsync(ProductCreateRequest request);
        Task<int> UpdateAsync(ProductUpdateRequest request);
        Task<int> DeleteAsync(int productId);
        Task<ProductViewModel> GetByIdAsync(int productId);
        Task<List<ProductViewModel>> GetAllAsync();
        Task<List<ProductViewModel>> GetByKeywordAsync(string keyWord);
    }
}
