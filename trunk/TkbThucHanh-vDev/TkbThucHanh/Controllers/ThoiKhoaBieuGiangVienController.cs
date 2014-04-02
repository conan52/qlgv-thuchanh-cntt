using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DluWebHelper;
using TkbThucHanh.Models;
using TkbThucHanh.Models.Provider;

namespace TkbThucHanh.Controllers
{
    public class ThoiKhoaBieuGiangVienController : Controller
    {
        //
        // GET: /ThoiKhoaBieuGiangVien/


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetNewTimeTable()
        {
            DluWebRequest request = new DluWebRequest();
            var table = request.GetCurentTimeTable();
            if (table.CurrentWeek > ThoiKhoaBieuProvider.GetLastTimeTable())
            {
                var teachers = GiangVienProvider.GetListTeacherCodes();
                var listTeachersInTable = table.TeacherCodes.Intersect(teachers);

                var courses = LopProvider.GetListCodes();
                var listcoursesInTable = table.TeacherCodes.Intersect(teachers);

                var fullTimeTable = TeacherFullTable.GetFullTimeTable(table.CurrentWeek, listcoursesInTable, listTeachersInTable);
                var result = ThoiKhoaBieuProvider.GetTeacherTimeTables(fullTimeTable, table.StartDate);
                DataProvider<TkbGiangVien>.Add(result);
                return Json(new { Status = 1 }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { Status = 0 }, JsonRequestBehavior.AllowGet);
        }



        TkbThucHanhContext db = new TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.TkbGangViens.Include("GiangVien").OrderByDescending(tkb => tkb.NgayHoc).ThenByDescending(tkb => tkb.TietBatDau);
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(TkbGiangVien item)
        {
            var model = db.TkbGangViens;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(TkbGiangVien item)
        {
            var model = db.TkbGangViens;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.MaTkb == item.MaTkb);
                    if (modelItem != null)
                    {
                        UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(Int32 maTkb)
        {
            var model = db.TkbGangViens;
            try
            {
                var item = model.FirstOrDefault(it => it.MaTkb == maTkb);
                if (item != null)
                    model.Remove(item);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ViewData["EditError"] = e.Message;
            }
            return PartialView("_GridViewPartial", model.ToList());
        }
    }
}
