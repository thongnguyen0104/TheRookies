using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.ViewModels
{
    public class CommentViewModel
    {
        private string _userAvatar;
        public string UserAvatar
        {
            get => string.IsNullOrEmpty(_userAvatar) ? string.Empty : _userAvatar;
            set => _userAvatar = value;
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
 
        [Range(1, 5)]
        public int Star { get; set; }
        public string Content { get; set; }

        public DateTime CreatedDate ;
    }
}
