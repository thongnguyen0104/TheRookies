﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        //public DateTime? RegisteredDate { get; set;}
        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
