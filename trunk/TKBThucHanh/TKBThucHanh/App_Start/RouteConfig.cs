using System.Web.Mvc;
using System.Web.Routing;

namespace TKBThucHanh
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "ActionSwitch",
              url: "{controller}/{action}/{subact}/{id}",
              defaults: new { controller = "Home", action = "Index", subact = UrlParameter.Optional, id = UrlParameter.Optional }
          );
        }
    }
}