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
    public class EfOrderDal : EfCoreGenericRepository<Order, CommerceContext>, IOrderDal
    {
        public List<Order> GetOrders(string userID)
        {
            using (var context = new CommerceContext())
            {
                var orders = context.Orders
                    .Include(i => i.OrderItems)
                    .ThenInclude(i => i.Product)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(userID))
                {
                    orders = orders.Where(i => i.UserID == userID);
                }
                return orders.ToList();
            }
        }
    }
}
