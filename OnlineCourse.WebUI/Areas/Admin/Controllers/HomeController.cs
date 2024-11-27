using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.WebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
