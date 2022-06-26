using Economic.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingResultBase
    {
        public int ProductTypeId { get; set; }
    }
}
