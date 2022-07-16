using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.ProductType
{
    public class ProductTypeUpdateRequest
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "IsDeleted")]
        public int IsDeleted { get; set; }
    }
}
