using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcPaging;
using TKBThucHanh.Function;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class GiangVienController : Controller
    {
        private readonly int _defaultPageSize = ContainValue.PageSize;

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();
//        public ActionResult Index()
//        {
//            return View(db.GiangViens.ToList());
//        }

        public ActionResult Index(string tengiangvien, int? page)
        {
            ViewData["tengiangvien"] = tengiangvien;
            int currentPageIndex = page.HasValue ? page.Value : 1;
            IList<GiangVien> giangViens = db.GiangViens.Cast<GiangVien>().ToList();

            if (string.IsNullOrWhiteSpace(tengiangvien))
            {
                giangViens = giangViens.ToPagedList(currentPageIndex, _defaultPageSize);
            }
            else
            {
                giangViens =
                    giangViens.Where(
                        p =>
                            StringUtility.LocDau(p.HoVaTen.ToLower())
                                .StartsWith(StringUtility.LocDau(tengiangvien.ToLower())))
                        .ToPagedList(currentPageIndex, _defaultPageSize);
            }


            //var list = 
            if (Request.IsAjaxRequest())
                return PartialView("_AjaxEmployeeList", giangViens);
            return View(giangViens);
        }

        public ActionResult Paging(string tengiangvien, int? page)
        {
            ViewData["tengiangvien"] = tengiangvien;
            int currentPageIndex = page.HasValue ? page.Value : 1;
            IList<GiangVien> giangViens = db.GiangViens.ToList();

            if (string.IsNullOrWhiteSpace(tengiangvien))
            {
                return RedirectToAction("Index");
            }
            else
            {
                giangViens =
                    giangViens.Where(
                        p =>
                            StringUtility.LocDau(p.HoVaTen.ToLower())
                                .StartsWith(StringUtility.LocDau(tengiangvien.ToLower())))
                        .ToPagedList(currentPageIndex, _defaultPageSize);
            }

            return View(giangViens);
        }

    }
}