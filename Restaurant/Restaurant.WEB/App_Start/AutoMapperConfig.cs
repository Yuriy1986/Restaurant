using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Restaurant.BLL.DTO;
using Restaurant.DAL.Entities;
using Restaurant.WEB.Models;

namespace Restaurant.WEB.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(
            cfg =>
            {
                //BLL.
                // OrderService / GetAllOrders.
                cfg.CreateMap<Order, DTOOrderViewModel>()
                    .ForMember(destination => destination.Dishes, opt => opt.MapFrom(src => src.Dishes.Select(x => x.Name)))
                    .ForMember(destination => destination.Chefs, opt => opt.MapFrom(src => src.Chefs.Select(x => x.Surname + " " + x.Name + " " + x.SecondName)))
                    .ForMember(destination => destination.Waiters, opt => opt.MapFrom(src => src.Waiters.Select(x => x.Surname + " " + x.Name + " " + x.SecondName)));

                ///////////////////////////////////////////////////////////////////////////////////////////////
                //WEB.
                // Home / GetAllOrders.
                cfg.CreateMap<DTOOrderViewModel, OrderViewModel>();
            }
            );
        }
    }
}