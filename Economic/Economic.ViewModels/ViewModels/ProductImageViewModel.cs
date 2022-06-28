using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.ViewModels
{
    public class ProductImageViewModel
    {
        private string _url;
        public int id { get; set; }
        public int ProductId { get; set; }
        public string ProductPath
        {
            get => string.IsNullOrEmpty(_url) ? string.Empty : _url;
            set => _url = value;
        }
    }
}
