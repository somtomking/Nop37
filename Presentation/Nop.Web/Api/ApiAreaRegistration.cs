using System.Web.Http;
using System.Web.Mvc;

namespace Nop.Api
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
           
           
            context.MapRoute(
                "Api_default",
                "ApiInfo/{controller}/{action}/{id}",
                new { controller = "Home",action="Index", area = "ApiInfo", id = UrlParameter.Optional },
                new[] { "Nop.Api.Controllers" }
            );
        }
    }
}
