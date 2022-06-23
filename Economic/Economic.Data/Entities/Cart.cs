using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Economic.Data.Entities
{
    public class Cart
    {
        [Key]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [Key]
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
