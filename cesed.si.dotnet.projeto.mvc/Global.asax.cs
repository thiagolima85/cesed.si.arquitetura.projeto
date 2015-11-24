
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using cesed.si.dotnet.projeto.mvc.AutoMapper;

namespace cesed.si.dotnet.projeto.mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
        }
    }
}
