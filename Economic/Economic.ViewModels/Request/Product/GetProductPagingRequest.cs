using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.Product
{
    public class GetProductPagingRequest
    {
#nullable enable
        public string? Keyword { get; set; }
        public List<int>? ProductTypeIds { get; set; }
#nullable disable
    }
}
