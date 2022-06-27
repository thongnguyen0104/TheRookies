using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Catalog.Products.Manage
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public IFormFile ThumbnailPath { get; set; }

    }
}
