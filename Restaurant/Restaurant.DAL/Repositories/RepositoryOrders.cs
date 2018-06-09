using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;

using Restaurant.DAL.Entities;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.EF;

namespace Restaurant.DAL.Repositories
{
    public class RepositoryOrders : IRepositoryOrders
    {
        RestaurantContext db;

        public RepositoryOrders(RestaurantContext context)
        {
            this.db = context;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return db.Orders.Include(dish => dish.Dishes).Include(waiter=>waiter.Waiters).Include(chef=>chef.Chefs);
        }
    }
}
