using Microsoft.AspNetCore.Mvc;
namespace OnlineCourse.Presentations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index action called.");
            return View();
        }
    }
}
