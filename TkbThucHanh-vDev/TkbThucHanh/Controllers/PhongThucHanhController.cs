using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TkbThucHanh.Controllers
{
    public class PhongThucHanhController : Controller
    {
        //
        // GET: /PhongThucHanh/

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            DbSet<PhongThucHanh> model = db.PhongThucHanhs;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(PhongThucHanh item)
        {
            DbSet<PhongThucHanh> model = db.PhongThucHanhs;
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
        public ActionResult GridViewPartialUpdate(PhongThucHanh item)
        {
            DbSet<PhongThucHanh> model = db.PhongThucHanhs;
            if (ModelState.IsValid)
            {
                try
                {
                    PhongThucHanh modelItem = model.FirstOrDefault(it => it.PhongThucHanhId == item.PhongThucHanhId);
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
        public ActionResult GridViewPartialDelete(Int32 PhongThucHanhId)
        {
            DbSet<PhongThucHanh> model = db.PhongThucHanhs;
            if (PhongThucHanhId != null)
            {
                try
                {
                    PhongThucHanh item = model.FirstOrDefault(it => it.PhongThucHanhId == PhongThucHanhId);
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