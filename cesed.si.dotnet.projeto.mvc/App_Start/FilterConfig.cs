using System.Web;
using System.Web.Mvc;

namespace cesed.si.dotnet.projeto.mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
