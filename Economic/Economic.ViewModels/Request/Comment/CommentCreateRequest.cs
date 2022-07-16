using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.Request.Comment
{
    public class CommentCreateRequest
    {
        [Required(ErrorMessage = "User Id is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Product Id is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Star is required.")]
        [Range(1, 5)]
        public int Star { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [MinLength(1)]
        public string Content { get; set; }
    }
}
