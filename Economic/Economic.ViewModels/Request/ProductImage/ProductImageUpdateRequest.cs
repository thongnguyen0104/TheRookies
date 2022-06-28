using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.ProductImage
{
    public class ProductImageUpdateRequest
    {
        [Required(ErrorMessage = "Product image Id is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Id is required.")]
        public int ProductId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
