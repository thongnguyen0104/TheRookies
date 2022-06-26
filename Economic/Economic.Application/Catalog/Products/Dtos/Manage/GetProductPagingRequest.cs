using Economic.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Economic.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingResultBase
    {
        public string Keyword { get; set; }

        public List<int> ProductTypeIds { get; set; }

    }
}
