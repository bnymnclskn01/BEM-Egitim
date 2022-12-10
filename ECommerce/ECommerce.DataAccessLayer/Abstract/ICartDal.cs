using ECommerce.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface ICartDal :IRepository<Cart>
    {
        Cart GetByUserId(string userID);
        void DeleteFromCart(Guid cartId, Guid productId);
        void ClearCart(string cartId);
    }
}
