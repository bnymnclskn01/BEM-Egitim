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

        [HttpGet("admin/urun-kategori-guncelle/{ID}")]
        public IActionResult Edit(Guid? ID)
        {
            if (ID == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var data = context.ProductCategories.Find(ID);
            if (data == null)
            {
                return RedirectToAction(nameof( Index));
            }
            return View(data);
        }
        [HttpPost("admin/urun-kategori-guncelle/{ID}")]
        public IActionResult Edit(Guid ID, ProductCategory productCategory)
        {
            var data = context.ProductCategories.Where(x => x.ID == ID).FirstOrDefault();
            if (ModelState.IsValid)
            {
                data.LastDate = DateTime.Now;
                data.Status = true;
                data.CategoryName = productCategory.CategoryName;
                data.Rank=productCategory.Rank;
                context.ProductCategories.Update(data);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(data);
        }

        [HttpGet("admin/urun-kategori-sil/{ID}")]
        public IActionResult Delete(Guid ID)
        {
            var model = context.ProductCategories.Find(ID);
            var liste = context.Products.Where(x => x.ProductCategoryID == ID).ToList();
            if (ModelState.IsValid)
            {
                context.ProductCategories.Remove(model);
                if (liste.Count() > 0)
                {
                    foreach (var item in liste)
                    {
                        context.Products.Remove(item);
                        context.SaveChanges();
                    }
                }
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
