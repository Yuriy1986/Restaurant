using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.EF;

namespace Restaurant.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        RestaurantContext db;

        RepositoryOrders repositoryOrders;

        public UnitOfWork(string connectionString)
        {
            db = new RestaurantContext(connectionString);
        }

        public IRepositoryOrders Orders
        {
            get
            {
                if (repositoryOrders == null)
                    repositoryOrders = new RepositoryOrders(db);
                return repositoryOrders;
            }
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
