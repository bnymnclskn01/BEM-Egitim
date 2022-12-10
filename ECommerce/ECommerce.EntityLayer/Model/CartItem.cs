using ECommerce.EntityLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Model
{
    [Table("CartItem", Schema = "dbo")]
    public class CartItem : BasicEntity
    {
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public Guid CartID { get; set; }
        public Cart Cart { get; set; }
        public int Quantity { get; set; }
    }
}
