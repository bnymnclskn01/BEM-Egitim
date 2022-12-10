using ECommerce.EntityLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Model
{
    [Table("OrderItem", Schema = "dbo")]
    public class OrderItem : BasicEntity
    {
        public Guid OrderID { get; set; }
        public Order Order { get; set; }

        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
