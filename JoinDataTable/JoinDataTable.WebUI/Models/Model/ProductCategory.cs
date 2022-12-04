using JoinDataTable.WebUI.Models.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoinDataTable.WebUI.Models.Model
{
    [Table("ProductCategory",Schema ="dbo")]
    public class ProductCategory : SeoEntity
    {
        public ProductCategory()
        {
            Products=new HashSet<Product>();
        }
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string Description { get; set; } = "";
        [Required]
        public string Slug { get; set; } = ""; //  Sayfanın url kısmını belirttiğimiz yer olacak

        public virtual ICollection<Product> Products { get; set; }
    }
}
