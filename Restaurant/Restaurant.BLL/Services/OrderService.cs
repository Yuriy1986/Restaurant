using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Restaurant.BLL.DTO;
using Restaurant.BLL.Interfaces;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<DTOOrderViewModel> GetAllOrders()
        {                
              return Mapper.Map<IEnumerable<Order>, IEnumerable<DTOOrderViewModel>>(Database.Orders.GetAllOrders());
        }
    }
}
