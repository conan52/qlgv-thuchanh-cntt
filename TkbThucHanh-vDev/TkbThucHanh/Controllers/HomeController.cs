using System.Web.Mvc;

namespace TkbThucHanh.Controllers
{
   // [Authorize(Roles = "AdminTeacher,Admin")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}