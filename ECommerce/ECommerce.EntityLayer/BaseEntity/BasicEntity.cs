using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.BaseEntity
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            ID= Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; set; }
    }
}
