﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL.Interfaces;
using Restaurant.DAL.Repositories;
using Autofac.Core;
using Autofac.Util;
using Autofac.Features;
using Autofac.Builder;
using Autofac;

namespace Restaurant.BLL.Infrastructure
{
    public class ServiceModule : Module
    {
        private string connectionString;
        public ServiceModule(string connection, ContainerBuilder builder)
        {
            connectionString = connection;
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().WithParameter("connectionString", connectionString);
        }
    }
}