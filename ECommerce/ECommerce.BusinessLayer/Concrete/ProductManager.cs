using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public bool Create(Product entity)
        {
            if (Validate(entity))
            {
                _productDal.Create(entity);
                return true;
            }
            return false;
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity); 
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(Guid ID)
        {
            return _productDal.GetById(ID);
        }

        public Product GetByIdWithCategories(Guid ID)
        {
            return _productDal.GetByIdWithCategories(ID);
        }

        public int GetCountByCategory(string category)
        {
            return _productDal.GetCountByCateogry(category);
        }

        public Product GetProductDetails(Guid ID)
        {
            return _productDal.GetProductDetails(ID);
        }

        public List<Product> GetProductsByCategory(string category, int page, int pageSize)
        {
            return _productDal.GetProductsByCategory(category, page, pageSize);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }

        public void Update(Product entity, Guid[] categoryIds)
        {
            _productDal.Update(entity, categoryIds);
        }

        public string ErrorMessage { get; set; }
        public bool Validate(Product entity)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Ürün isimini girmeniz zorunludur";
                isValid = false;
            }
            return isValid;
        }
    }
}
