using ECommerce.DataAccessLayer.Abstract;
using ECommerce.EntityLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Concrete.EfCoreMSSql
{
    public class EfProductDal : EfCoreGenericRepository<Product, CommerceContext>, IProductDal
    {
        public Product GetByIdWithCategories(Guid ID)
        {
            using(var context = new CommerceContext())
            {
                return context.Products
                    .Where(i => i.ID == ID)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public int GetCountByCateogry(string category)
        {
           using(var context = new CommerceContext())
            {
                var products=context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
                }
                return products.Count();
            }
        }

        public Product GetProductDetails(Guid ID)
        {
            using (var context = new CommerceContext())
            {
                return context.Products
                    .Where(i => i.ID == ID)
                    .Include(i=>i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public List<Product> GetProductsByCategory(string category, int page, int pageSize)
        {
            using (var context = new CommerceContext())
            {
                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products =products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a=>a.Category.Name.ToLower() == category.ToLower()));
                }
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        public void Update(Product entity, Guid[] categoryIds)
        {
            using(var context= new CommerceContext()) 
            {
                var product = context.Products
                    .Include(i => i.ProductCategories)
                    .FirstOrDefault(i => i.ID == entity.ID);
                if (product != null)
                {
                    product.Name = entity.Name;
                    product.Description = entity.Description;
                    product.ImageUrl= entity.ImageUrl;
                    product.Price= entity.Price;
                    product.ProductCategories = categoryIds.Select(catId => new ProductCategory()
                    {
                        CategoryID= catId,
                        ProductID=entity.ID
                    }).ToList();
                    context.SaveChanges();
                }
            }
        }
    }
}
