using Economic.Utilities.SystemConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.ViewModels.ViewModels
{
    public class ProductImageViewModel
    {
        private string _fileurl;
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string FileUrl
        {
            get => string.IsNullOrEmpty(_fileurl) ? SystemConstants.DEFAULT_PRODUCT_IMAGE_URL : _fileurl;
            set => _fileurl = value;
        }
        public string ProductPath
        {
            get ;
            set ;
        }
    }
}
