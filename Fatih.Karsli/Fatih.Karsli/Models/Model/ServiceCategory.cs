using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fatih.Karsli.Models.Model
{
    [Table("ServiceCategories", Schema = "dbo")]
    public class ServiceCategory :BasicEntity.BasicEntity
    {
        public ServiceCategory()
        {
            Services = new HashSet<Service>();
        }
        public int Rank { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
