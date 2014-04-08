using System.Web.Security;
using TKBThucHanh.Models;
using WebMatrix.WebData;

namespace TKBThucHanh.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<TkbThucHanhContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TkbThucHanhContext context)
        {
            if (!WebSecurity.Initialized)
                WebSecurity.InitializeDatabaseConnection("TkbThucHanh", "UserProfile", "UserId", "UserName", true);
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
