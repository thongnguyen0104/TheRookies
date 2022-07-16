using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.Product
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "Product type is required.")]
        [Display(Name = "ProductType")]
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product price is required.")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Product description is required.")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        //public int IsDeleted { get; set; }
    }
}
