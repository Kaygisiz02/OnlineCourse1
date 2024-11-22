using Microsoft.AspNetCore.Mvc;
namespace OnlineCourse.Repositoryies
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
