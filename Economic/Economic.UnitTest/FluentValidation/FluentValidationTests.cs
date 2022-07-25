using Economic.Data.Configurations;
using Economic.ViewModels.Request.ProductType;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.UnitTest.FluentValidation
{
    [TestClass]
    public class FluentValidationTests
    {
        private ProductTypeCreateRequest productTypeCreateRequest;

        [TestInitialize]
        public void TestInitialize()
        {
            productTypeCreateRequest = new ProductTypeCreateRequest();
        }
    }
}
