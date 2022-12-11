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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Create(Category entity)
        {
            _categoryDal.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void DeleteFromCategory(Guid categoryID, Guid productID)
        {
            _categoryDal.DeleteFromCategory(categoryID, productID);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(Guid ID)
        {
            return _categoryDal.GetById(ID);
        }

        public Category GetByIdWithProduct(Guid ID)
        {
            return _categoryDal.GetByIdWithProducts(ID);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
