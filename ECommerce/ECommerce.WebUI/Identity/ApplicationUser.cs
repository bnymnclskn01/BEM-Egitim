using Microsoft.AspNetCore.Identity;

namespace ECommerce.WebUI.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
