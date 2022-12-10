using ECommerce.EntityLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Model
{
    [Table("Category",Schema ="dbo")]
    public  class Category : BasicEntity
    {
        public Category()
        {
            ProductCategories = new List<ProductCategory>();
        }
        public string Name { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }
    }
}
