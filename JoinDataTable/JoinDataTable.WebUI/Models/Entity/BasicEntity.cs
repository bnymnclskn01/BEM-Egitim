using System.ComponentModel.DataAnnotations;

namespace JoinDataTable.WebUI.Models.Entity
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            ID = Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
    }
}
