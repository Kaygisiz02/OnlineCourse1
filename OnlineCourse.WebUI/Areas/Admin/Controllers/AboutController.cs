using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.WebUI.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        [Area("Admin")]
        [Route("[area]/[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
