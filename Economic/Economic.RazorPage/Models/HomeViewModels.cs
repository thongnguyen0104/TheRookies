using Economic.ViewModels.ViewModels;

namespace Economic.RazorPage.Models
{
    public class HomeViewModels
    {
        public List<ProductViewModel> Products;
        public List<ProductTypeViewModel> ProductTypes;
        public ProductViewModel Product;
        public List<CommentViewModel> Comments;
        public List<ProductViewModel> SameProducts;
        public string keyword;

    }
}
