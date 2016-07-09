using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Nop.Api
{
    public class RouteProvider : IRouteProvider
    {
        public int Priority
        {
            get
            {
               return 100;
            }
        }

        public void RegisterRoutes(RouteCollection routes)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
          
        }
    }
}