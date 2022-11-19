using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCDERSUI.Models.DatabaseModelContext;
using MVCDERSUI.Models.Entity;

namespace MVCDERSUI.Controllers
{

    public class ProductController : Controller
    {
        private MvcDersDatabaseModelContext context = new MvcDersDatabaseModelContext();

        [HttpGet("admin/urun-listele")]
        public IActionResult Index()
        {
            var model = context.Products.Include(x => x.ProductCategory).ToList().OrderBy(x => x.Rank);
            return View(model);
        }

        [Route("admin/urun-ekle/{ID}")]
        [Route("admin/urun-ekle")]
        [HttpGet]
        public IActionResult CreateEdit(Guid? ID)
        {
            var model = context.Products.Include(x => x.ProductCategory).Where(x => x.ID == ID).FirstOrDefault();
            if (ID==null)
            {
                ViewBag.ProductCategoryID = new SelectList(context.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.Rank), "ID", "CategoryName");
                return View();
            }
            else
            {
                ViewBag.ProductCategoryID = new SelectList(context.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.Rank), "ID", "CategoryName",model.ProductCategoryID);
                return View(model);
            }
        }

        [Route("admin/urun-ekle/{ID}")]
        [Route("admin/urun-ekle")]
        [HttpPost]
        public IActionResult CreateEdit(Guid? ID, Product product)
        {
            var model = context.Products.Include(x => x.ProductCategory).Where(x => x.ID == ID).FirstOrDefault();
            if (model == null)
            {
                product.Status = true;
                product.CreateDate = DateTime.Now;
                product.LastDate = DateTime.Now;
                context.Products.Add(product);
                context.SaveChanges();
                ViewBag.ProductCategoryID = new SelectList(context.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.Rank), "ID", "CategoryName");
                return RedirectToAction(nameof(Index));
            }
            else
            {
                model.Rank = product.Rank;
                model.Status = true;
                model.LastDate = DateTime.Now;
                model.ProductCategoryID = product.ProductCategoryID;
                model.ProductName = product.ProductName;
                context.Products.Update(model);
                context.SaveChanges();
                ViewBag.ProductCategoryID = new SelectList(context.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.Rank), "ID", "CategoryName", model.ProductCategoryID);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
