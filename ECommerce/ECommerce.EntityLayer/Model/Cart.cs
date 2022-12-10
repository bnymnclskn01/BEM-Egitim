using ECommerce.EntityLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Model
{
    [Table("Cart",Schema ="dbo")]
    public class Cart : BasicEntity
    {
        public string UserID { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
