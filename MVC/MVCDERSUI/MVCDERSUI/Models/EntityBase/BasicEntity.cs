
using System.ComponentModel.DataAnnotations;

namespace MVCDERSUI.Models.EntityBase
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            this.ID = Guid.NewGuid();
            this.Status = false;
        }
        [Key]
        public Guid ID { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}
