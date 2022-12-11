using ECommerce.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IProductService
    {
        Product GetById(Guid ID);
        Product GetByIdWithCategories(Guid ID);
        Product GetProductDetails(Guid ID);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string category, int page, int pageSize);
        int GetCountByCategory(string category);
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        void Update(Product entity, Guid[] categoryIds);
    }
}
