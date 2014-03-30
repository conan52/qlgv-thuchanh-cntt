using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TKBThucHanh.Models;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class PhongHocController : Controller
    {

        //
        // GET: /PhongHoc/

        public ActionResult Index()
        {
            var db = new TkbThucHanhContext();

            return View(db.PhongThucHanhs.ToList());
        }


        [HttpGet]
        public ActionResult Delete(string id)
        {
            var db = new TkbThucHanhContext();
            var ph = db.PhongThucHanhs.SingleOrDefault(p => p.TenPhong.Equals(id));
            db.PhongThucHanhs.Remove(ph);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
