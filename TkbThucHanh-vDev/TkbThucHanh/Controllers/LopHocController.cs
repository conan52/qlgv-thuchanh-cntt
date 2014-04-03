using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TkbThucHanh.Controllers
{
    public class LopHocController : Controller
    {
        //
        // GET: /LopHoc/

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            DbSet<Lop> model = db.Lops;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(Lop item)
        {
            DbSet<Lop> model = db.Lops;
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
        public ActionResult GridViewPartialUpdate(Lop item)
        {
            DbSet<Lop> model = db.Lops;
            if (ModelState.IsValid)
            {
                try
                {
                    Lop modelItem = model.FirstOrDefault(it => it.TenLop == item.TenLop);
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
        public ActionResult GridViewPartialDelete(string TenLop)
        {
            DbSet<Lop> model = db.Lops;
            if (TenLop != null)
            {
                try
                {
                    Lop item = model.FirstOrDefault(it => it.TenLop == TenLop);
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