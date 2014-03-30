using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TKBThucHanh.Models;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class GiangVienController : Controller
    {
        //
        // GET: /GiangVien/

        public ActionResult Index()
        {
            var db = new TkbThucHanhContext();
            return View(db.GiangViens);
        }

    }
}
