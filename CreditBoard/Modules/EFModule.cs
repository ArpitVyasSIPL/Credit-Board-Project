using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CreditBoard.DTO;
using CreditBoard.Repository;
using System.Data.Entity;

namespace CreditBoard.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(CreditBoardContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();

        }
    }
}