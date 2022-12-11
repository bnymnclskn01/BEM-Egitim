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
    public class EfCartDal : EfCoreGenericRepository<Cart, CommerceContext>, ICartDal
    {
        public void ClearCart(string cartId)
        {
            using (var context = new CommerceContext())
            {
                var cmd = @"delete from CartItem where ID=@p0";
                context.Database.ExecuteSqlRaw(cmd, cartId);
            }
        }

        public void DeleteFromCart(Guid cartId, Guid productId)
        {
            using(var context = new CommerceContext()) 
            {
                var cmd = @"delete from CartItem where ID=@p0 And ProductID=@p1";
                context.Database.ExecuteSqlRaw(cmd,cartId,productId);
            }
        }

        public Cart GetByUserId(string userID)
        {
            using (var context = new CommerceContext())
            {
                return context
                    .Carts
                    .Include(i => i.CartItems)
                    .ThenInclude(i => i.Product)
                    .FirstOrDefault(i => i.UserID == userID);
            }
        }
        public override void Update(Cart entity)
        {
            using(var context = new CommerceContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
