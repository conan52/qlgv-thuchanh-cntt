using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TkbThucHanh.Controllers
{
    public class MonHocController : Controller
    {
        //
        // GET: /MonHoc/

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            DbSet<MonHoc> model = db.MonHocs;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(MonHoc item)
        {
            DbSet<MonHoc> model = db.MonHocs;
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
        public ActionResult GridViewPartialUpdate(MonHoc item)
        {
            DbSet<MonHoc> model = db.MonHocs;
            if (ModelState.IsValid)
            {
                try
                {
                    MonHoc modelItem = model.FirstOrDefault(it => it.MonHocId == item.MonHocId);
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
        public ActionResult GridViewPartialDelete(Int32 MonHocId)
        {
            DbSet<MonHoc> model = db.MonHocs;
            if (MonHocId != null)
            {
                try
                {
                    MonHoc item = model.FirstOrDefault(it => it.MonHocId == MonHocId);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartial", model.ToList());
        }
    }
}