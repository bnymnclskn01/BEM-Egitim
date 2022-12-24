using System.ComponentModel.DataAnnotations;

namespace ECommerce.WebUI.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(dataType:DataType.Password)]
        public string Password { get; set; }
    }
}
