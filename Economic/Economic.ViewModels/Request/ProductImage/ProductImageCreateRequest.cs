using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.ProductImage
{
    public class ProductImageCreateRequest
    {
        public int ProductId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
