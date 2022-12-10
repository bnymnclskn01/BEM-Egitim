using ECommerce.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface IProductDal :IRepository<Product>
    {
        List<Product> GetProductsByCategory(string category,int page,int pageSize);
        Product GetProductDetails(Guid ID);
        int GetCountByCateogry(string category);
        Product GetByIdWithCategories(Guid ID);
        void Update(Product entity, Guid[] categoryIds);
    }
}
