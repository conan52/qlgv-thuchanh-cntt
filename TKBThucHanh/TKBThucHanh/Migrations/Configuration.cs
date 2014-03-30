using System.Web.Security;
using WebMatrix.WebData;

namespace TKBThucHanh.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TKBThucHanh.Models.TkbThucHanhContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TKBThucHanh.Models.TkbThucHanhContext context)
        {
            //if (!WebSecurity.Initialized)
            //    WebSecurity.InitializeDatabaseConnection("TkbThucHanh", "UserProfile", "UserId", "UserName", true);
            //if (!Roles.RoleExists("Administrator"))
            //    Roles.CreateRole("Administrator");
            //if (!WebSecurity.UserExists("admin"))
            //{
            //    WebSecurity.CreateUserAndAccount("admin", "admin");
            //    Roles.AddUserToRole("admin", "Administrator");
            //}
        }
    }
}
