using MVCDERSUI.Models.EntityBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDERSUI.Models.Entity
{
    [Table("ProductCategories",Schema ="dbo")]
    public class ProductCategory : BasicEntity
    {
        public ProductCategory()
        {
            CategoryName = "";
            Rank = 0;
            Products=new HashSet<Product>();
        }
        public string CategoryName { get; set; } // Kategori Adı
        public int Rank { get; set; } // Kategori Sıra

        public virtual ICollection<Product> Products { get; set; }
    }
}
