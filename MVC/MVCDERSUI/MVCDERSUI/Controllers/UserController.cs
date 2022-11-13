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
        [HttpGet("User/Edit/{id}")]
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var data = context.UserMembers.Find(id);
            if (data == null)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
        [HttpPost("User/Edit/{id}")]
        public IActionResult Edit(Guid id, UserMember userMember)
        {
            var data = context.UserMembers.Find(id);
            if (ModelState.IsValid)
            {
                data.NameSurname = userMember.NameSurname;
                data.LastDate = DateTime.Now;
                data.Email = userMember.Email;
                data.Password = userMember.Password;
                data.UserNote = userMember.UserNote;
                context.UserMembers.Update(data);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(data);
            }
        }
        public IActionResult Delete(Guid id)
        {
            var data = context.UserMembers.Find(id);
            if (ModelState.IsValid)
            {
                context.UserMembers.Remove(data);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
