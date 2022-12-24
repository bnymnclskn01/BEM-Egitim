using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Model;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    [Authorize("admin")]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        #region Product
        public IActionResult ProductList()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View(new ProductModel());
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl
                };
                if (_productService.Create(entity))
                {
                    return RedirectToAction(nameof(ProductList));
                }
                ViewBag.ErrorMessage = _productService.ErrorMessage;
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditProduct(Guid? ID)
        {
            if (ID == null)
                return NotFound();
            var entity = _productService.GetByIdWithCategories((Guid)ID);
            if (entity == null)
                return NotFound();
            var model = new ProductModel()
            {
                Id = entity.ID,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductModel model, Guid[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _productService.GetById(model.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                entity.Description = model.Description;
                entity.Price = model.Price;
                if (file != null)
                {
                    entity.ImageUrl = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _productService.Update(entity, categoryIds);
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Guid productId)
        {
            var entity = _productService.GetById(productId);
            if (entity != null)
                _productService.Delete(entity);
            return RedirectToAction(nameof(ProductList));
        }
        #endregion
        #region Category
        public IActionResult CategoryList()
        {
            return View(new CategoryListModel()
            {
                Categories = _categoryService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            var entity = new Category()
            {
                Name = model.Name,
            };
            _categoryService.Create(entity);
            return RedirectToAction(nameof(CategoryList));
        }

        [HttpGet]
        public IActionResult EditCategory(Guid id)
        {
            var entity = _categoryService.GetByIdWithProduct(id);
            return View(new CategoryModel { ID = entity.ID, Name = entity.Name, Products = entity.ProductCategories.Select(p => p.Product).ToList() });
        }

        [HttpPost]
        public IActionResult EditCategory(CategoryModel model)
        {
            var entity = _categoryService.GetById(model.ID);
            if (entity == null)
                return NotFound();
            entity.Name = model.Name;
            _categoryService.Update(entity);
            return RedirectToAction(nameof(CategoryList));
        }

        [HttpPost]
        public IActionResult DeleteFromCategory(Guid categoryId, Guid productId)
        {
            _categoryService.DeleteFromCategory(categoryId, productId);
            return Redirect("/Admin/EditCategory/" + categoryId);
        }
        #endregion
    }
}