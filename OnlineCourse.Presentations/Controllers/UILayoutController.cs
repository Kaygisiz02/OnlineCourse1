using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Presentations.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
