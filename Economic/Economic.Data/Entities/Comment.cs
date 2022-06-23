using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Economic.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Range(1, 5)]
        public int Star { get; set; }

        public string Content { get; set; }
        public DateTime? Created { get; set; }
    }
}
