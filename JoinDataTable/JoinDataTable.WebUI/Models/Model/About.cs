using JoinDataTable.WebUI.Models.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoinDataTable.WebUI.Models.Model
{
    [Table("About", Schema = "dbo")]
    public class About :BasicEntity
    {
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string Description { get; set; } = "";
        [Required]
        public string ImageUrl { get; set; } = "";
        public string? VideoUrl { get; set; }
        public string? PdfUrl { get; set; }
    }
}
