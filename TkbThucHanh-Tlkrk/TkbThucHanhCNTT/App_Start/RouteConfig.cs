using System.Web.Mvc;
using System.Web.Routing;

namespace TkbThucHanhCNTT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                //  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                new {controller = "GiangVien", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}