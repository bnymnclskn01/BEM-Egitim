using Microsoft.AspNetCore.Mvc;
using MVCDERSUI.Models.DatabaseModelContext;

namespace MVCDERSUI.Controllers
{
    public class LoginController : Controller
    {
        private MvcDersDatabaseModelContext context = new MvcDersDatabaseModelContext();
        [HttpGet("Login/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Login/Index")]
        public IActionResult Index(string Email, string Password)
        {
            var data = context.UserMembers.Where(x => x.Email == Email && x.Password == Password).ToList();
            if (data.Count() > 0)
            {
                HttpContext.Session.SetString("ID", data.FirstOrDefault().ID.ToString());
                HttpContext.Session.SetString("NameSurname", data.FirstOrDefault().NameSurname);
                HttpContext.Session.SetString("Email", data.FirstOrDefault().Email);
                var url = "/User/Index/";
                Response.Redirect(url);
                return View();
            }
            else
            {
                ViewBag.Hata = "Lütfen bilgileri doğru girdiğinizden emin olunuz.";
                return View(data);
            }
        }

        [HttpGet("Login/Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
