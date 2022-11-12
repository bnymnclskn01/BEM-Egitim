using Microsoft.AspNetCore.Mvc;
using MVCDERSUI.Models.DatabaseModelContext;
using MVCDERSUI.Models.Entity;

namespace MVCDERSUI.Controllers
{
    public class UserController : Controller
    {
        private MvcDersDatabaseModelContext context=new MvcDersDatabaseModelContext();
        public IActionResult Index()
        {
            var model = context.UserMembers.ToList().OrderByDescending(x=>x.ID);
            return View(model);
        }

        [HttpGet("User/Create/")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("User/Create")]
        public IActionResult Create(UserMember userMember)
        {
            userMember.CreateDate = DateTime.Now;
            userMember.LastDate = DateTime.Now;
            userMember.Status = true;
            context.UserMembers.Add(userMember);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
