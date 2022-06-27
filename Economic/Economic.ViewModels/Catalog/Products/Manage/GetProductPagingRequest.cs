using Economic.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Economic.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingResultBase
    {
        public string Keyword { get; set; }
        public List<int> ProductTypeId { get; set; }

    }
}
