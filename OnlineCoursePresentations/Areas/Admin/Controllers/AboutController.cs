using Microsoft.AspNetCore.Mvc;

namespace OnlineCoursePresentations.Areas.Admin.Controllers
{
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
