using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SorunTakipSistemiEntityLayer.DatabaseModelContext;
using SorunTakipSistemiEntityLayer.Model;

namespace SorunTakipSistemi.WEBUI.Controllers
{
    public class UserRoleController : Controller
    {
        private SorunTakipDatabaseModelContext _context = new SorunTakipDatabaseModelContext();
        [Route("rol-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await _context.UserMemberRoles.ToListAsync();
            return View(model);
        }

        [Route("rol-ekle")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("rol-ekle/{ID}")]
        [Route("rol-ekle")]
        public async Task<IActionResult> Create(UserMemberRole userMemberRole)
        {
            var control = await _context.UserMemberRoles.Where(x => x.RoleName.ToLower() == userMemberRole.RoleName.ToLower()).FirstOrDefaultAsync();
            if (ModelState.IsValid)
            {
                if (control == null)
                {
                    userMemberRole.CreateDate = DateTime.Now;
                    userMemberRole.UpdateDate = DateTime.Now;
                    userMemberRole.Status = true;
                    _context.UserMemberRoles.Add(userMemberRole);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Hata = "Böyle bir rol veritabanımızda bulunduğundan dolayı bu kayıdı ekleyemiyoruz.";
                    return View(userMemberRole);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [Route("rol-guncelle/{ID}")]
        public async Task<IActionResult> Edit(Guid? ID)
        {
            if (ID == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var model = await _context.UserMemberRoles.Where(x => x.ID == ID).FirstOrDefaultAsync();
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [Route("rol-guncelle/{ID}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid ID, UserMemberRole userMemberRole)
        {
            var model = await _context.UserMemberRoles.Where(x => x.ID == ID).FirstOrDefaultAsync();
            if (ModelState.IsValid)
            {
                model.Status = userMemberRole.Status;
                model.UpdateDate = DateTime.Now;
                model.RoleNote = userMemberRole.RoleNote;
                model.RoleCode = userMemberRole.RoleCode;
                model.RoleName = userMemberRole.RoleName;
                _context.UserMemberRoles.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
