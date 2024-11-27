using Microsoft.AspNetCore.Mvc;
namespace OnlineCourse.Repositoryies.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
