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
    public class CartManager : ICartService
    {
        private ICartDal _cartDal;
        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void AddToCart(string userID, Guid productID, int quantity)
        {
            var cart = GetCartByUserId(userID);
            if (cart != null)
            {
                var index=cart.CartItems.FindIndex(x => x.ProductID == productID);
                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem()
                    {
                        ProductID = productID,
                        Quantity = quantity,
                        CartID = cart.ID
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;
                }
                _cartDal.Update(cart);
            }
        }

        public void ClearCart(string cartID)
        {
            _cartDal.ClearCart(cartID);
        }

        public void DeleteFromCart(string userID, Guid productID)
        {
            var cart=GetCartByUserId(userID);
            if (cart != null)
            {
                _cartDal.DeleteFromCart(cart.ID,productID);
            }
        }

        public Cart GetCartByUserId(string userID)
        {
            return _cartDal.GetByUserId(userID);
        }

        public void InitializeCart(string userID)
        {
            _cartDal.Create(new Cart() { UserID = userID });
        }
    }
}
