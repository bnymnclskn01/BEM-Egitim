using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
