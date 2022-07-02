using Economic.ViewModels.Request.ProductType;
using Economic.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Interface
{
    public interface IProductTypeService
    {
        Task<int> CreateAsync(ProductTypeCreateRequest request);
        Task<int> UpdateAsync(ProductTypeUpdateRequest request);
        Task<int> DeleteAsync(int id);
        Task<List<ProductTypeViewModel>> GetAllAsync();
        Task<ProductTypeViewModel> GetByIdAsync(int id);
    }
}
