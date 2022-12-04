using System.ComponentModel.DataAnnotations;

namespace JoinDataTable.WebUI.Models.Entity
{
    public class SeoEntity
    {
        public SeoEntity()
        {
            ID= Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public string? seoTitle { get; set; }
        public string? seoKeywords { get; set; }
        public string? seoDescription { get; set; }
        public string? seoAuthor { get; set; }
        public string? seoCopyright { get; set; }
        public string? seoDesign { get; set; }
        public string? seoReply { get; set; }
        public string? seoSubject { get; set; }
    }
}
