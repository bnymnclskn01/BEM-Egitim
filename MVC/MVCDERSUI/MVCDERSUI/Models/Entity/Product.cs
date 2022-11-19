using MVCDERSUI.Models.EntityBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDERSUI.Models.Entity
{
    [Table("Products",Schema ="dbo")]
    public class Product : BasicEntity
    {
        public Product()
        {
            Rank = 0;
            ProductName = "";
            ProductDescription = "";
        }
        public int Rank { get; set; } // Ürünler Arasında Sıralama
        public string ProductName { get; set; } // Ürün Adı
        public string ProductDescription { get; set; } // Ürün Açıklama

        public Guid ProductCategoryID { get; set; } //Ürün Kategori
        public ProductCategory ProductCategory { get; set; }
    }
}
