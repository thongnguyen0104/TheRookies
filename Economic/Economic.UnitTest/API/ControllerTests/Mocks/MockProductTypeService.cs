using Economic.Application.Interface;
using Economic.ViewModels.Request.ProductType;
using Economic.ViewModels.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.UnitTest.API.ControllerTests.Mocks
{
    public class MockProductTypeService : Mock<IProductTypeService>
    {
        public MockProductTypeService MockGetAllAsync(List<ProductTypeViewModel> result)
        {
            Setup(x => x.GetAllAsync()).Returns(Task.FromResult(result));
            return this;
        }
        public MockProductTypeService MockGetAllAsync_ThrowException()
        {
            Setup(x => x.GetAllAsync()).Throws(new Exception());
            return this;
        }
        public MockProductTypeService MockGetByIdAsync(ProductTypeViewModel result)
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }
        public MockProductTypeService MockGetByIdAsync_ThrowException()
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }
        public MockProductTypeService MockCreateAsync(int result)
        {
            Setup(x => x.CreateAsync(It.IsAny<ProductTypeCreateRequest>())).ReturnsAsync(result);
            return this;
        }
        public MockProductTypeService MockCreateAsync_ThrowException()
        {
            Setup(x => x.CreateAsync(It.IsAny<ProductTypeCreateRequest>())).Throws(new Exception());
            return this;
        }
        public MockProductTypeService MockUpdateAsync(int result)
        {
            Setup(x => x.UpdateAsync(It.IsAny<ProductTypeUpdateRequest>())).ReturnsAsync(result);
            return this;
        }
        public MockProductTypeService MockUpdateAsync_ThrowException()
        {
            Setup(x => x.UpdateAsync(It.IsAny<ProductTypeUpdateRequest>())).Throws(new Exception());
            return this;
        }

    }
}
