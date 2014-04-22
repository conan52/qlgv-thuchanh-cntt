using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TkbThucHanhCNTT.Filters;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    public class RegisterAdminController : Controller
    {
        //
        // GET: /RegisterAdmin/
        public ActionResult Index()
        {
            if(DataProvider<UserProfile>.GetAll().Count(x => x.Role=="AdminTeacher")==0)
                return View();
            return RedirectToAction("Login", "Account");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [InitializeSimpleMembership]
        public ActionResult Index(RegisterAdminModelView register)
        {
            if (register != null && ModelState.IsValid)
            {
                string userName = StaticUltils.GetUsername(register.HoVaTen);
                if (AccountController.TaoTaiKhoan(new RegisterModel()
                {
                    UserName = userName,
                    Password = "123456",
                    Roles = "AdminTeacher",
                    MaGv = register.MaGv
                }))
                {
                    var g = new GiangVien()
                    {
                        ChuyenNganh = ChuyenNganh.CoBan,
                        CoThePhanCong = true,
                        MaGv = register.MaGv.ToUpper(),
                        HoVaTen = register.HoVaTen,
                    };
                    DataProvider<GiangVien>.Add(g);
                    var up = DataProvider<UserProfile>.GetSingle(x => x.MaGv == register.MaGv);
                    g.UserProfile = up;
                    g.UserProfileId = up.UserId;
                    DataProvider<GiangVien>.Update(g);
                    AccountController.SetRole(g.UserProfile.UserName, "AdminTeacher");
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(register);
        }

    }
}
