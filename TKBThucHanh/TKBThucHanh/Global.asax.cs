using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using TKBThucHanh.Models;
using WebMatrix.WebData;

namespace TKBThucHanh
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            var db = new TkbThucHanhContext();
            db.Database.Initialize(true);

            if (!WebSecurity.Initialized)
                WebSecurity.InitializeDatabaseConnection("TkbCloud", "UserProfile", "UserId", "UserName", true);
            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");
            if (!WebSecurity.UserExists("admin"))
            {
                WebSecurity.CreateUserAndAccount("admin", "admin");
                Roles.AddUserToRole("admin", "Administrator");
            }
        }
    }
}