using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Areas.Admin.Models;
using WebApplication1.Services;

namespace WebApplication1
{
    public class WebModule : Module
    {
        
        protected override void Load(ContainerBuilder builder)
        { 

            builder.RegisterType<SimpleDatabaseService>().As<IDatabaseService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseListModel>().AsSelf();

            base.Load(builder);
        }

    }
}
