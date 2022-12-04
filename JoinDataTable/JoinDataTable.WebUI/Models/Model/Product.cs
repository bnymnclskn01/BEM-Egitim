using JoinDataTable.WebUI.Models.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoinDataTable.WebUI.Models.Model
{
    [Table("Product",Schema ="dbo")]
    public class Product : SeoEntity
    {

        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string Description { get; set; } = "";
        [Required]
        public string ImageUrl { get; set; } = "";
        public string? VideoUrl { get; set; }
        public string? PdfUrl { get; set; }
        public Guid ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [Required]
        public string Slug { get; set; } = "";
    }
}
