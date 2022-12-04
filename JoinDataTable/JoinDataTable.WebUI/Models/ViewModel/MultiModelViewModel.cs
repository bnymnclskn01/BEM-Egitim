using JoinDataTable.WebUI.Models.Model;

namespace JoinDataTable.WebUI.Models.ViewModel
{
    public class MultiModelViewModel
    {
        public virtual About Abouts { get; set; }
        public virtual IList<ProductCategory> ProductCategories { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
