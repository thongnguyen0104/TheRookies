using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.Product
{
    public class ProductUpdateRequest
    {
        [Required(ErrorMessage = "Product Id is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product type is required.")]
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product price is required.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Product Price Description")]
        public string Description { get; set; }
    }
}
