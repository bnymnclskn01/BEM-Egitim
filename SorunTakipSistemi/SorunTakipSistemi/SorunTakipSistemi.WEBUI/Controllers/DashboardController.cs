using Microsoft.AspNetCore.Mvc;

namespace SorunTakipSistemi.WEBUI.Controllers
{
    public class DashboardController : Controller
    {
        [Route("gosterge-paneli")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
