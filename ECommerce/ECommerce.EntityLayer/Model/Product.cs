using ECommerce.EntityLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Model
{
    [Table("Product", Schema = "dbo")]
    public class Product : BasicEntity
    {
        public Product()
        {
            ProductCategories = new List<ProductCategory>();
        }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
