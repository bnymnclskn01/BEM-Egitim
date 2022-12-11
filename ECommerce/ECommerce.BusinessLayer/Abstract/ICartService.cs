using ECommerce.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userID);
        Cart GetCartByUserId(string userID);
        void AddToCart(string userID, Guid productID, int quantity);
        void DeleteFromCart(string userID, Guid productID);
        void ClearCart(string cartID);
    }
}
