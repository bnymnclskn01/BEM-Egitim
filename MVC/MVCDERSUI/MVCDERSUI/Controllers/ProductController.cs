using Microsoft.AspNetCore.Mvc;
using MVCDERSUI.Models.DatabaseModelContext;

namespace MVCDERSUI.Controllers
{

    public class ProductController : Controller
    {
        private MvcDersDatabaseModelContext context = new MvcDersDatabaseModelContext();

        [HttpGet("admin/urun-listele")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
