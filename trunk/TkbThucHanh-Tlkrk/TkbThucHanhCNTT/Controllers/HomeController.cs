using System.Web.Mvc;

namespace TkbThucHanhCNTT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("AdminTeacher"))
                return RedirectToAction("Index", "LichThucHanh");
            if(User.IsInRole("Admin"))
                return RedirectToAction("Index", "Account");
            return RedirectToAction("LichThucHanhGV", "LichThucHanh");
        }
    }
}
