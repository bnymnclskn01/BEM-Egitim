using Microsoft.AspNetCore.Mvc;
using MVCDERSUI.Models.DatabaseModelContext;
using MVCDERSUI.Models.Entity;

namespace MVCDERSUI.Controllers
{
    public class ProductCategoryController : Controller
    {
        private MvcDersDatabaseModelContext context = new MvcDersDatabaseModelContext();
        [HttpGet("admin/urun-kategori-listele")]
        public IActionResult Index()
        {
            var data = context.ProductCategories.OrderBy(x => x.Rank).ToList();
            return View(data);
        }

        [HttpGet("admin/urun-kategori-ekle")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("admin/urun-kategori-ekle")]
        public IActionResult Create(ProductCategory productCategory)
        {
            var control = context.ProductCategories.Where(x => x.CategoryName == productCategory.CategoryName).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (control != null)
                {
                    ViewBag.Hata = "Girdiğiniz kayı sistemimizde mevcut olduğundan dolayı ekleme işlemi yapamıyoruz. Kayıt Bilgilerini Kontrol Edip Tekrar Deneyiniz.";
                    return View(productCategory);
                }
                else
                {
                    productCategory.CreateDate = DateTime.Now;
                    productCategory.LastDate = DateTime.Now;
                    productCategory.Status = true;
                    context.ProductCategories.Add(productCategory);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(productCategory);
        }
    }
}
