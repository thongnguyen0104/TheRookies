using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Dtos
{
    public class PagingResultBase
    {
        public int PageIndex { get; set; } 

        public int PageSize { get; set; }
    }
}
