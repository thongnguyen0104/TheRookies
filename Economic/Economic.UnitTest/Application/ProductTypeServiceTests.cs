using Economic.Application.Services;
using Economic.Data.EF;
using Economic.Data.Entities;
using Economic.ViewModels.Request.ProductType;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.UnitTest.Application
{
    public class ProductTypeServiceTests
    {
        [Fact]
        public async Task CreateProductType_ReturnsSuccess()
        {
            //var guid = "BFF91064-DC92-421E-A233-D1080F630928";
            //Arrange
            var builder = new DbContextOptionsBuilder<EconomicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());

            var dbContext = new EconomicDbContext(builder.Options);

            var productService = new ProductService(dbContext);

            var productTypeService = new ProductTypeService(dbContext, productService);

            var request = new ProductTypeCreateRequest()
            {
                Name = "Demo service test",
                Description = "Mo ta service test"
            };

            //Act
            var result = await productTypeService.CreateAsync(request);

            //Assert
            Assert.NotNull(result.ToString());
        }

        [Fact]
        public async Task CreateProductType_WhenNameNotExistsReturns0()
        {
            var guid = "BFF91054-DC92-421E-A233-D1080F630928";
            //Arrange
            var builder = new DbContextOptionsBuilder<EconomicDbContext>().UseInMemoryDatabase(guid.ToString());

            var dbContext = new EconomicDbContext(builder.Options);

            var productService = new ProductService(dbContext);

            var productTypeService = new ProductTypeService(dbContext, productService);

            var request = new ProductTypeCreateRequest()
            {
                Description = "Mo ta service test"
            };

            //Act
            var result = await productTypeService.CreateAsync(request);

            //Assert
            Assert.NotNull(result.ToString());
        }

        [Fact]
        public async void GetAllProductType_ReturnsList()
        {
            var guid = "BFF91054-DC92-421E-A233-D1080F630928";
            //Arrange
            var builder = new DbContextOptionsBuilder<EconomicDbContext>().UseInMemoryDatabase(guid.ToString());

            var dbContext = new EconomicDbContext(builder.Options);

            var list = new List<ProductType>()
            {
                new ProductType()
                {
                    Name = "Test1",
                    Description = "Test 1"
                },
                new ProductType()
                {
                    Name = "Test2",
                    Description = "Test 2"
                },
                new ProductType()
                {
                    Name = "Test3",
                    Description = "Test 3"
                },
                new ProductType()
                {
                    Name = "Test4",
                    Description = "Test 4"
                },
            };

            dbContext.ProductTypes.AddRange(list);
            dbContext.SaveChanges();

            var productService = new ProductService(dbContext);
            var productTypeService = new ProductTypeService(dbContext, productService);

            //Act
            var result = await productTypeService.GetAllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(4, result.Count);
            Assert.Equal("Test1", result[0].Name);
            Assert.Equal("Test4", result[3].Name);
        }

        [Fact]
        public async Task UpdateProductType_ReturnsSuccess()
        {
            var guid = "BFF91054-DC92-421E-A233-D1080F630928";
            //Arrange
            var builder = new DbContextOptionsBuilder<EconomicDbContext>().UseInMemoryDatabase(guid.ToString());

            var dbContext = new EconomicDbContext(builder.Options);

            var list = new List<ProductType>()
            {
                new ProductType()
                {
                    Name = "Test1",
                    Description = "Test 1"
                },
                new ProductType()
                {
                    Name = "Test2",
                    Description = "Test 2"
                },
                new ProductType()
                {
                    Name = "Test3",
                    Description = "Test 3"
                },
                new ProductType()
                {
                    Name = "Test4",
                    Description = "Test 4"
                },
            };

            dbContext.ProductTypes.AddRange(list);
            dbContext.SaveChanges();

            var request = new ProductTypeUpdateRequest
            {
                Id = 30,
                Name = "Test Update",
                Description = "Test update proType service test"
            };

            var productService = new ProductService(dbContext);
            var productTypeService = new ProductTypeService(dbContext, productService);

            //Act
            var result = await productTypeService.UpdateAsync(request);

            //Assert
            Assert.Equal(1, result);
            Assert.NotNull(result.ToString());
        }
    }
}
