using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Presentation
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
