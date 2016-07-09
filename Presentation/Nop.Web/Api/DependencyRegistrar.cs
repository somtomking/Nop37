using Nop.Core.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Reflection;

namespace Nop.Api
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order
        {
            get
            {
                return 0;
            }
        }

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var resolver = new AutofacWebApiDependencyResolver(EngineContext.Current.ContainerManager.Container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}