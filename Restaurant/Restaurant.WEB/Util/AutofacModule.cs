using Autofac;
using Restaurant.BLL.Interfaces;
using Restaurant.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.WEB.Util
{
    public class AutofacModule : Module
    {
        public AutofacModule(ContainerBuilder builder)
        {
            builder.RegisterType<OrderService>().As<IOrderService>();
        }
    }
}