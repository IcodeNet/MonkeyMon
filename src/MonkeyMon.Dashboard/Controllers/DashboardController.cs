using System.Web.Mvc;

namespace MonkeyMon.Dashboard.Content
{
    public class DashboardController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}