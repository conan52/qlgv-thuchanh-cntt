using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.Web.WebPages.OAuth;
using TkbThucHanhCNTT.Filters;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;
using TkbThucHanhCNTT.Models.Viewer;
using WebMatrix.WebData;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    [InitializeSimpleMembership]
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            ViewData["GiangViens"] =
                DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new {gv.HoVaTen, gv.MaGv});
            ViewData["Roles"] = EnumUltils.GetDescriptions_QuyenHan();
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, UserProfileViewModel up)
        {
            // Test if gv object and modelstate is valid.
            if (up != null && ModelState.IsValid)
            {
                var uf = new UserProfile
                {
                    //    Email = up.Email,
                    MaGv = up.MaGv,
                    Role = up.QuyenHan,
                    UserId = up.UserId,
                    UserName = up.TenDangNhap
                };
                SetRole(uf.UserName, uf.Role);
                DataProvider<UserProfile>.Update(uf);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        public static void SetRole(string userName, string value)
        {
            foreach (EnumInfo info in EnumUltils.GetDescriptions_QuyenHan())
            {
                if (!Roles.RoleExists(info.Name))
                    Roles.CreateRole(info.Name);
            }
            foreach (string role in Roles.GetAllRoles())
            {
                try
                {
                    Roles.RemoveUserFromRole(userName, role);
                }
                catch (Exception)
                {
                }
            }
            Roles.AddUserToRole(userName, value);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            IList<UserProfile> result = DataProvider<UserProfile>.GetAll();
            return Json(result.ToDataSourceResult(request, up => new UserProfileViewModel
            {
                MaGv = up.MaGv,
                QuyenHan = up.Role,
                UserId = up.UserId,
                TenDangNhap = up.UserName
            }));
        }

        //
        // GET: /Account/Login

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            RedirectToAction("Index", "RegisterAdmin");
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                GiangVien k = DataProvider<GiangVien>.GetAll(x => x.UserProfile)
                    .FirstOrDefault(t => StaticUltils.GetUsername(t.HoVaTen) == model.UserName);
                if ((k != null && k.UserProfile != null) || model.UserName == "Admin")
                {
                    if ((k != null && (k.CoThePhanCong && k.UserProfile.Role != "Blocked")) || model.UserName == "Admin")
                    {
                        if (WebSecurity.Login(model.UserName, model.Password, model.RememberMe))
                        {
                            HttpCookie httpCookie = Response.Cookies[0];
                            if (httpCookie != null) httpCookie.Expires = DateTime.Now.AddDays(30);
                            StaticValue.MaGv = DataProvider<UserProfile>.GetSingle(x => x.UserName == model.UserName).MaGv;
                            return RedirectToLocal(returnUrl);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tài khoản này đang bị khóa");
                        return View(model);
                    }
                }

                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không chính xác");
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult LogOff()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult DoiMatKhau(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Đổi mật khẩu thành công."
                    : message == ManageMessageId.SetPasswordSuccess ? "Mật khẩu này đang được đặt."
                        : message == ManageMessageId.ErrorPassword ? "Mật khẩu cũ không đúng!"
                            : "";
            bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            if (hasLocalAccount)
                return PartialView("DoiMatKhau");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoiMatKhau(LocalPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (!WebSecurity.Login(User.Identity.Name, model.OldPassword))
                    return RedirectToAction("DoiMatKhau", new {Message = ManageMessageId.ErrorPassword});
                if (WebSecurity.Login(User.Identity.Name, model.NewPassword))
                    return RedirectToAction("DoiMatKhau", new {Message = ManageMessageId.SetPasswordSuccess});
                bool changePasswordSucceeded;
                try
                {
                    changePasswordSucceeded = WebSecurity.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("DoiMatKhau", new {Message = ManageMessageId.ChangePasswordSuccess});
                }
                ModelState.AddModelError("", "Mật khẩu hiện tại không đúng.");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public JsonResult ResetMatKhau(int userid)
        {
            UserProfile userProfile = DataProvider<UserProfile>.GetSingle(x => x.UserId == userid);
            try
            {
                string token = WebSecurity.GeneratePasswordResetToken(userProfile.UserName);
                WebSecurity.ResetPassword(token, "123456");
                return Json(new {Result = "OK", Message = "Đổi mật khẩu thành công"});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        [HttpPost]
        public JsonResult LuuThongSoTrang(string page)
        {
            try
            {
                StaticValue.PageNumber = int.Parse(page);
                return Json(new {Result = "OK", Message = "Đổi số trang hiển thị thành công"});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        public ViewResult CauHinhTrangWeb()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ResetCauHinh()
        {
            try
            {
                DataProvider<TuanHoc>.RemoveAll();
                DataProvider<LichCongTac>.RemoveAll();
                DataProvider<PhanCongGiangDay>.RemoveAll();
                return Json(new {Result = "OK", Message = "Đã làm mới toàn bộ dữ liệu"});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        public ActionResult ThemTaiKhoanTuDong()
        {
            try
            {
                int count = 0;
                List<GiangVien> giangViens = DataProvider<GiangVien>.GetAll(x => x.UserProfile).Where(x => x.UserProfile == null).ToList();
                foreach (GiangVien giangVien in giangViens)
                {
                    string userName = StaticUltils.GetUsername(giangVien.HoVaTen);
                    if (TaoTaiKhoan(new RegisterModel
                    {
                        UserName = userName,
                        Password = "123456",
                        Roles = "Teacher",
                        MaGv = giangVien.MaGv
                    }))
                    {
                        UserProfile up = DataProvider<UserProfile>.GetSingle(x => x.MaGv == giangVien.MaGv);
                        giangVien.UserProfile = up;
                        giangVien.UserProfileId = up.UserId;
                        DataProvider<GiangVien>.Update(giangVien);
                        count++;
                    }
                }
                return Json(new {Result = "OK", Message = string.Format("Đã thêm {0} tài khoản", count)});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        #region Helpers

        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            ErrorPassword
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }


        [InitializeSimpleMembership]
        public static bool TaoTaiKhoan(RegisterModel model)
        {
            try
            {
                WebSecurity.CreateUserAndAccount(model.UserName, model.Password, new {model.MaGv, Role = model.Roles});
                SetRole(model.UserName, model.Roles);
                return true;
            }
            catch
            {
                List<UserProfile> listuser = DataProvider<UserProfile>.GetAll().Where(x => x.UserName == model.UserName).ToList();
                if (listuser.Count() > 1)
                    DataProvider<UserProfile>.Remove(listuser.ElementAt(1));
                return false;
            }
        }

        #endregion
    }
}