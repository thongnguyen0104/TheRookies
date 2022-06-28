using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.ProductImage
{
    public class ProductImageCreateRequest
    {
        [Required(ErrorMessage = "Product Id is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product image is required.")]
        public IFormFile ImageFile { get; set; }
    }
}
