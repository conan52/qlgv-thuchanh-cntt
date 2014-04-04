using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TkbThucHanh.Controllers
{
  //  [Authorize(Roles = "AdminTeacher,Admin")]
    public class TuanController : Controller
    {
        //
        // GET: /Tuan/

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            DbSet<TuanHoc> model = db.TuanHocs;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(TuanHoc item)
        {
            DbSet<TuanHoc> model = db.TuanHocs;
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
                ViewData["EditError"] = "Có lỗi xảy ra. Vui lòng xem chi tiết!";
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(TuanHoc item)
        {
            DbSet<TuanHoc> model = db.TuanHocs;
            if (ModelState.IsValid)
            {
                try
                {
                    TuanHoc modelItem = model.FirstOrDefault(it => it.SttTuan == item.SttTuan);
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
                ViewData["EditError"] = "Có lỗi xảy ra. Vui lòng xem chi tiết!";
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(Int32 SttTuan)
        {
            DbSet<TuanHoc> model = db.TuanHocs;
            try
            {
                TuanHoc item = model.FirstOrDefault(it => it.SttTuan == SttTuan);
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