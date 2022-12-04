using JoinDataTable.WebUI.Models.DataContext;
using JoinDataTable.WebUI.Models.Helper;
using JoinDataTable.WebUI.Models.Model;
using JoinDataTable.WebUI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;

namespace JoinDataTable.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private JoinDataModelContext _context = new JoinDataModelContext();
        public async Task<IActionResult>MultiModel()
        {
            var about = await _context.Abouts.Where(x => x.IsActive == true).FirstOrDefaultAsync();
            var productCategory = await _context.ProductCategories.Include(x => x.Products).Where(x => x.IsActive == true).ToListAsync();
            var product = await _context.Products.Include(x => x.ProductCategory).Where(x => x.IsActive == true).ToListAsync();
            MultiModelViewModel multiModelViewModel = new() { Abouts = about, ProductCategories = productCategory, Products = product };
            return View(multiModelViewModel);
        }
        #region About
        public async Task<IActionResult> AboutList()
        {
            var model = await _context.Abouts.ToListAsync();
            return View(model);
        }
        public IActionResult AboutCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AboutCreate(About about, IFormFile ImageUrl, IFormFile VideoUrl, IFormFile PdfUrl)
        {
            var aboutControl = await _context.Abouts.Where(x => x.Title.ToLower() == about.Title.ToLower()).FirstOrDefaultAsync();
            if (ModelState.IsValid)
            {
                if (aboutControl != null)
                {
                    ViewBag.Control = "Bu başlığa ait kayıt bulunmaktadır.";
                    return View(about);
                }
                else
                {
                    if (ImageUrl != null)
                    {
                        var extension = Path.GetExtension(ImageUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "jpg", "jpeg", "png", "webp" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı jpg, jpeg,png,webp formatindaki dosyalar kabul ediliyor";
                            return View(about);
                        }
                        var url_path = Guid.NewGuid().ToString() + ImageUrl.FileName;
                        var local_image_dir = $"wwwroot/Image/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            ImageUrl.CopyTo(fileStream);
                        }
                        about.ImageUrl = $"{url_path}";
                    }
                    if (VideoUrl != null)
                    {
                        var extension = Path.GetExtension(VideoUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "mp4", "webm" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı mp4, webm formatindaki dosyalar kabul ediliyor";
                            return View(about);
                        }
                        var url_path = Guid.NewGuid().ToString() + VideoUrl.FileName;
                        var local_image_dir = $"wwwroot/Video/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            VideoUrl.CopyTo(fileStream);
                        }
                        about.VideoUrl = $"{url_path}";
                    }
                    if (PdfUrl != null)
                    {
                        var extension = Path.GetExtension(PdfUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "pdf" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı pdf formatindaki dosyalar kabul ediliyor";
                            return View(about);
                        }
                        var url_path = Guid.NewGuid().ToString() + PdfUrl.FileName;
                        var local_image_dir = $"wwwroot/PDF/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            PdfUrl.CopyTo(fileStream);
                        }
                        about.PdfUrl = $"{url_path}";
                    }
                    about.IsActive = true;
                    _context.Abouts.Add(about);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(AboutList));
                }
            }
            return View(about);
        }

        public async Task<IActionResult> AboutEdit(Guid? ID)
        {
            if (ID == null)
                return RedirectToAction(nameof(AboutList));
            var About = await _context.Abouts.FindAsync(ID);
            if (About == null)
                return RedirectToAction(nameof(AboutList));
            return View(About);
        }

        [HttpPost]
        public async Task<IActionResult> AboutEdit(Guid ID, About about, IFormFile ImageUrl, IFormFile VideoUrl, IFormFile PdfUrl)
        {
            var dataControl = await _context.Abouts.Where(x => x.Title.ToLower() == about.Title.ToLower() && x.ID != ID).FirstOrDefaultAsync();
            var data = await _context.Abouts.FindAsync(ID);
            if (ModelState.IsValid)
            {
                if (dataControl != null)
                {
                    ViewBag.Hata = "Sistemde böyle bir başlık olduğu için güncelleme yapamıyoruz.";
                    return View(data);
                }
                else
                {
                    if (ImageUrl != null)
                    {
                        if (System.IO.File.Exists("wwwroot/Image/" + data.ImageUrl))
                        {
                            System.IO.File.Delete("wwwroot/Image/" + data.ImageUrl);
                        }
                        var extension = Path.GetExtension(ImageUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "jpg", "jpeg", "png", "webp" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı jpg, jpeg,png,webp formatindaki dosyalar kabul ediliyor";
                            return View(data);
                        }
                        var url_path = Guid.NewGuid().ToString() + ImageUrl.FileName;
                        var local_image_dir = $"wwwroot/Image/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            ImageUrl.CopyTo(fileStream);
                        }
                        data.ImageUrl = $"{url_path}";
                    }
                    if (VideoUrl != null)
                    {
                        if (System.IO.File.Exists("wwwroot/Video/" + data.VideoUrl))
                        {
                            System.IO.File.Delete("wwwroot/Video/" + data.VideoUrl);
                        }
                        var extension = Path.GetExtension(VideoUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "mp4", "webm" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı mp4, webm formatindaki dosyalar kabul ediliyor";
                            return View(data);
                        }
                        var url_path = Guid.NewGuid().ToString() + VideoUrl.FileName;
                        var local_image_dir = $"wwwroot/Video/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            VideoUrl.CopyTo(fileStream);
                        }
                        data.VideoUrl = $"{url_path}";
                    }
                    if (PdfUrl != null)
                    {
                        if (System.IO.File.Exists("wwwroot/PDF/" + data.PdfUrl))
                        {
                            System.IO.File.Delete("wwwroot/PDF/" + data.PdfUrl);
                        }
                        var extension = Path.GetExtension(PdfUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "pdf" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı pdf formatindaki dosyalar kabul ediliyor";
                            return View(about);
                        }
                        var url_path = Guid.NewGuid().ToString() + PdfUrl.FileName;
                        var local_image_dir = $"wwwroot/PDF/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            PdfUrl.CopyTo(fileStream);
                        }
                        data.PdfUrl = $"{url_path}";
                    }
                    data.ID = about.ID;
                    data.IsActive = about.IsActive;
                    data.Title = about.Title;
                    data.Description = about.Description;
                    _context.Abouts.Update(data);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(AboutList));
                }
            }
            else
            {
                return View(about);
            }
        }

        public async Task<IActionResult> AboutDelete(Guid ID)
        {
            var data = await _context.Abouts.FindAsync(ID);
            if (ModelState.IsValid)
            {
                if (System.IO.File.Exists("wwwroot/Image/" + data.ImageUrl))
                {
                    System.IO.File.Delete("wwwroot/Image/" + data.ImageUrl);
                }
                if (System.IO.File.Exists("wwwroot/Video/" + data.VideoUrl))
                {
                    System.IO.File.Delete("wwwroot/Video/" + data.ImageUrl);
                }
                if (System.IO.File.Exists("wwwroot/PDF/" + data.PdfUrl))
                {
                    System.IO.File.Delete("wwwroot/PDF/" + data.PdfUrl);
                }
                _context.Abouts.Remove(data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AboutList));
            }
            return View(data);
        }
        #endregion

        #region Product
        public async Task<IActionResult> ProductList()
        {
            var model = await _context.Products.Include(x => x.ProductCategory).ToListAsync();
            return View(model);
        }
        public IActionResult ProductCreate()
        {
            ViewBag.ProductCategoryID = new SelectList(_context.ProductCategories.Where(x => x.IsActive == true).OrderBy(X => X.Title), "ID", "Title");
            return View();
        }
        [HttpPost]
        [Route("Home/ProductCreate")]
        public async Task<IActionResult> ProductCreate(Product product, IFormFile ImageUrl, IFormFile VideoUrl, IFormFile PdfUrl)
        {
            var prod = await _context.Products
                .Include(x => x.ProductCategory)
                .Where(x => x.Title.ToLower() == product.Title.ToLower())
                .FirstOrDefaultAsync();
            if (ModelState.IsValid) 
            {
                if (prod != null)
                {
                    ViewBag.Hata = "Sistemde böyle bir kayıt zaten bulunmaktadır. Lütfen Yeni Kayıt Oluşturun.";
                    return View(product);
                }
                else
                {
                    if (ImageUrl != null)
                    {
                        var extension = Path.GetExtension(ImageUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "jpg", "jpeg", "png", "webp" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı jpg, jpeg,png,webp formatindaki dosyalar kabul ediliyor";
                            return View(product);
                        }
                        var url_path = Guid.NewGuid().ToString() + ImageUrl.FileName;
                        var local_image_dir = $"wwwroot/Image/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            ImageUrl.CopyTo(fileStream);
                        }
                        product.ImageUrl = $"{url_path}";
                    }
                    if (VideoUrl != null)
                    {
                        var extension = Path.GetExtension(VideoUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "mp4", "webm" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı mp4, webm formatindaki dosyalar kabul ediliyor";
                            return View(product);
                        }
                        var url_path = Guid.NewGuid().ToString() + VideoUrl.FileName;
                        var local_image_dir = $"wwwroot/Video/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            VideoUrl.CopyTo(fileStream);
                        }
                        product.VideoUrl = $"{url_path}";
                    }
                    if (PdfUrl != null)
                    {
                        var extension = Path.GetExtension(PdfUrl.FileName).Trim('.').ToLower();
                        if (!(new[] { "pdf" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Dosya uzantısı hatalı pdf formatindaki dosyalar kabul ediliyor";
                            return View(product);
                        }
                        var url_path = Guid.NewGuid().ToString() + PdfUrl.FileName;
                        var local_image_dir = $"wwwroot/PDF/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            PdfUrl.CopyTo(fileStream);
                        }
                        product.PdfUrl = $"{url_path}";
                    }
                    product.IsActive = true;
                    product.Slug = StringHelper.StringReplacer(product.Title.ToLower());
                    //Title = Bilgisayar Çantası - Slug = /urun/bilgisayar-cantasi
                    _context.Products.Add(product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(ProductList));
                }
            }
            else
            {
                return View(product);
            }
        }

        public async Task<IActionResult> PorudctEdit(Guid? ID)
        {
            if (ID == null)
            {
                return RedirectToAction(nameof(ProductList));
            }
            var product= await _context.Products
                .Where(x=>x.ID==ID)
                .Include(x=>x.ProductCategory)
                .FirstOrDefaultAsync();
            ViewBag.ProductCategoryID = new SelectList(_context.ProductCategories.Where(x => x.IsActive == true).OrderBy(X => X.Title), "ID", "Title",product.ProductCategoryID);
            if (product == null)
            {
                return RedirectToAction(nameof(ProductList));
            }
            return View(product);
        }

		[HttpPost]
		[Route("Home/PorudctEdit/{ID}")]
		public async Task<IActionResult> PorudctEdit(Guid ID, Product product, IFormFile ImageUrl, IFormFile VideoUrl, IFormFile PdfUrl)
        {
            var data = await _context.Products
                .Where(x => x.ID == ID)
                .Include(x => x.ProductCategory)
                .FirstOrDefaultAsync();
            if (ModelState.IsValid)
            {
                if (ImageUrl != null)
                {
                    if (System.IO.File.Exists("wwwroot/Image/" + data.ImageUrl))
                    {
                        System.IO.File.Delete("wwwroot/Image/" + data.ImageUrl);
                    }
                    var extension = Path.GetExtension(ImageUrl.FileName).Trim('.').ToLower();
                    if (!(new[] { "jpg", "jpeg", "png", "webp" }.Contains(extension)))
                    {
                        ViewBag.Hata = "Dosya uzantısı hatalı jpg, jpeg,png,webp formatindaki dosyalar kabul ediliyor";
                        return View(data);
                    }
                    var url_path = Guid.NewGuid().ToString() + ImageUrl.FileName;
                    var local_image_dir = $"wwwroot/Image/";
                    var local_image_path = $"{local_image_dir}/{url_path}";
                    if (!Directory.Exists(Path.Combine(local_image_dir)))
                        Directory.CreateDirectory(Path.Combine(local_image_dir));
                    using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                    {
                        ImageUrl.CopyTo(fileStream);
                    }
                    data.ImageUrl = $"{url_path}";
                }
                if (VideoUrl != null)
                {
                    if (System.IO.File.Exists("wwwroot/Video/" + data.VideoUrl))
                    {
                        System.IO.File.Delete("wwwroot/Video/" + data.VideoUrl);
                    }
                    var extension = Path.GetExtension(VideoUrl.FileName).Trim('.').ToLower();
                    if (!(new[] { "mp4", "webm" }.Contains(extension)))
                    {
                        ViewBag.Hata = "Dosya uzantısı hatalı mp4, webm formatindaki dosyalar kabul ediliyor";
                        return View(data);
                    }
                    var url_path = Guid.NewGuid().ToString() + VideoUrl.FileName;
                    var local_image_dir = $"wwwroot/Video/";
                    var local_image_path = $"{local_image_dir}/{url_path}";
                    if (!Directory.Exists(Path.Combine(local_image_dir)))
                        Directory.CreateDirectory(Path.Combine(local_image_dir));
                    using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                    {
                        VideoUrl.CopyTo(fileStream);
                    }
                    data.VideoUrl = $"{url_path}";
                }
                if (PdfUrl != null)
                {
                    if (System.IO.File.Exists("wwwroot/PDF/" + data.PdfUrl))
                    {
                        System.IO.File.Delete("wwwroot/PDF/" + data.PdfUrl);
                    }
                    var extension = Path.GetExtension(PdfUrl.FileName).Trim('.').ToLower();
                    if (!(new[] { "pdf" }.Contains(extension)))
                    {
                        ViewBag.Hata = "Dosya uzantısı hatalı pdf formatindaki dosyalar kabul ediliyor";
                        return View(product);
                    }
                    var url_path = Guid.NewGuid().ToString() + PdfUrl.FileName;
                    var local_image_dir = $"wwwroot/PDF/";
                    var local_image_path = $"{local_image_dir}/{url_path}";
                    if (!Directory.Exists(Path.Combine(local_image_dir)))
                        Directory.CreateDirectory(Path.Combine(local_image_dir));
                    using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                    {
                        PdfUrl.CopyTo(fileStream);
                    }
                    data.PdfUrl = $"{url_path}";
                }
                data.ID = product.ID;
                data.ProductCategoryID = product.ProductCategoryID;
                data.seoKeywords = product.seoKeywords;
                data.seoCopyright = product.seoCopyright;
                data.seoAuthor = product.seoAuthor;
                data.seoReply = product.seoReply;
                data.Title= product.Title;
                data.Description= product.Description;
                data.seoDesign = product.seoDesign;
                data.IsActive = product.IsActive;
                data.seoDescription = product.seoDescription;
                data.seoTitle= product.seoTitle;
                data.seoSubject = product.seoSubject;
                data.Slug = StringHelper.StringReplacer(product.Title.ToLower());
                _context.Products.Add(data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProductList));
            }
            else
            {
                return View(data);
            }
        }

        public async Task<IActionResult> ProductDelete(Guid ID)
        {
            var prod = await _context.Products
                .Include(x => x.ProductCategory)
                .Where(x => x.ID == ID)
                .FirstOrDefaultAsync();

            if (ModelState.IsValid)
            {
                _context.Products.Remove(prod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProductList));
            }
            return View(prod);
        }
        #endregion

        #region Product Category
        #endregion

        #region Ödeviniz
        /*
        About Sayfasının Viewları Size Ait Siz Yapacaksınız
        Product Category Controller Siz Oluştuurup Sayfalırını Siz Yapacaksınız
        En az  Tablolu en az 2 Tablo birbiriyle ilişkili Bir şekilde Sadece Crud
        (Create(Ekleme) Edit(Güncelleme) Read(Okuma- Listeleme) Delete(Silme))
        İşlemleri Yapacaksınız.
         */
        #endregion
    }
}
