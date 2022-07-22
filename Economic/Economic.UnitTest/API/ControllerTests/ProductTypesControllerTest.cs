using Economic.Api.Controllers;
using Economic.UnitTest.API.ControllerTests.Mocks;
using Economic.ViewModels.Request.ProductType;
using Economic.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.UnitTest.API.ControllerTests
{
    public class ProductTypesControllerTest
    {
        // Test for ProductType API
        [Fact]
        public async void Get_ReturnsOk()
        {
            var mockData = new List<ProductTypeViewModel>()
            {
                new ProductTypeViewModel()
                {
                    Id = 1,
                },
            };
            var mockProductTypeService = new MockProductTypeService().MockGetAllAsync(mockData);
            var controller = new ProductTypesController(mockProductTypeService.Object);
            var result = await controller.Get() as OkObjectResult;
            Assert.NotNull(result);
            var contnet = result.Value as List<ProductTypeViewModel>;
            Assert.NotNull(contnet);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockData, contnet);
            Assert.IsType<List<ProductTypeViewModel>>(contnet);

        }
        [Fact]
        public async void Get_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockGetAllAsync_ThrowException();
            var controller = new ProductTypesController(mockProductTypeService.Object);
            var result = await controller.Get();
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void GetById_ReturnsOk()
        {
            var mockData = new ProductTypeViewModel()
            {
                Id = 1,
            };
            var mockProductTypeService = new MockProductTypeService().MockGetByIdAsync(mockData);
            var controller = new ProductTypesController(mockProductTypeService.Object);
            var result = await controller.GetById(1) as OkObjectResult;
            var content = result.Value as ProductTypeViewModel;
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<ProductTypeViewModel>(content);
        }
        [Fact]
        public async void GetById_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockGetByIdAsync_ThrowException();

            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.GetById(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void Create_WithValidModel_ReturnsOk()
        {
            var mockProductTypeService = new MockProductTypeService().MockCreateAsync(1).MockGetByIdAsync(new ProductTypeViewModel());
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Create(new ProductTypeCreateRequest()) as OkObjectResult;
            Assert.IsType<OkObjectResult>(result);
            var content = result.Value as ProductTypeViewModel;
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<ProductTypeViewModel>(content);
        }
        [Fact]
        public async void Create_WithValidModelAndProductTypeIdIsZero_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockCreateAsync_ThrowException();
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Create(new ProductTypeCreateRequest());
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void Create_WithInValidModel_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockCreateAsync(2);
            var controller = new ProductTypesController(mockProductTypeService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Create(new ProductTypeCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void Create_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockProductTypeService = new MockProductTypeService().MockCreateAsync(2).MockGetByIdAsync(null);
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Create(new ProductTypeCreateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        public async void Update_WithValidModel_ReturnsOk()
        {
            var mockProductTypeService = new MockProductTypeService().MockUpdateAsync(1).MockGetByIdAsync(new ProductTypeViewModel());
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Update(new ProductTypeUpdateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
            var content = result.Value as ProductTypeViewModel;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<ProductTypeViewModel>(content);
        }
        [Fact]
        public async void Update_WithValidModelAndException_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockUpdateAsync_ThrowException();
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Update(new ProductTypeUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void Update_WithInValidModel_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockUpdateAsync(2);
            var controller = new ProductTypesController(mockProductTypeService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Update(new ProductTypeUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void Update_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockProductTypeService = new MockProductTypeService().MockUpdateAsync(2).MockGetByIdAsync(null);
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Update(new ProductTypeUpdateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        public async void Delete_ReturnsOk()
        {
            var mockProductTypeService = new MockProductTypeService().MockDeleteAsync(1);
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public async void Delete_ReturnsBadRequest()
        {
            var mockProductTypeService = new MockProductTypeService().MockDeleteAsync_ThrowException();
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public async void Delete_ReturnsNotFound()
        {
            var mockProductTypeService = new MockProductTypeService().MockDeleteAsync(0);
            var controller = new ProductTypesController(mockProductTypeService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<NotFoundObjectResult>(result);
        }

    }
}
