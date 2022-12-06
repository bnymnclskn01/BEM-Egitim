using Fatih.Karsli.Models.BasicEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fatih.Karsli.Models.Model
{
    [Table("Services", Schema = "dbo")]
    public class Service : ContentEntity
    {
        public int Rank { get; set; }
        public Guid ServiceCategoryID { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
    }
}
