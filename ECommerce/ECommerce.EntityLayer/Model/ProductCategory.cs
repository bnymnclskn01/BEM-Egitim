using ECommerce.EntityLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Model
{
    [Table("ProductCategory",Schema ="dbo")]
    public class ProductCategory
    {
        public Guid CategoryID { get; set; }
        public Category Category { get; set; }
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
    }
}
