﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Catalog.Products.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
