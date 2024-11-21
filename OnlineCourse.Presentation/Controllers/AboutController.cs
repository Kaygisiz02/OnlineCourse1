using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;
using OnlineCourse.Entity;

namespace OnlineCourse.Presentation.Controllers
{
    public class AboutController(IAboutService aboutService) : Controller
    {
        readonly IAboutService _aboutService = aboutService;
        public IActionResult Index()
        {
            var aboutData = _aboutService.GetAllAbouts(); // Örnek olarak tüm "About" verilerini alıyoruz
            return View(aboutData);
        }
    }
}
