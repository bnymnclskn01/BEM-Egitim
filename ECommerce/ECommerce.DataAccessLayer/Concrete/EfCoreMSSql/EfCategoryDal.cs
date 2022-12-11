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
    public class EfCategoryDal : EfCoreGenericRepository<Category, CommerceContext>, ICategoryDal
    {
        public void DeleteFromCategory(Guid categoryID, Guid productId)
        {
            using(var context= new CommerceContext())
            {
                var cmd = @"delete from ProductCategory where ProductID=@p0 And CategoryID=@p1";
                context.Database.ExecuteSqlRaw(cmd, productId, categoryID);
            }
        }

        public Category GetByIdWithProducts(Guid ID)
        {
            using (var context= new CommerceContext())
            {
                return context
                    .Categories
                    .Where(i => i.ID == ID)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Product)
                    .FirstOrDefault();
            }
        }
    }
}
