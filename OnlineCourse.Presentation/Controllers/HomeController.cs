using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentation.Controllers
{
    public class HomeController(IAboutService aboutService) : Controller
    {
        private readonly IAboutService _aboutService=aboutService;
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            // Ana sayfa için gerekli veriler ve işlem mantığı
            return View();
        }

        public IActionResult About()
        {
            // Hakkımızda sayfası
            ViewData["Message"] = "Uygulama hakkında bilgiler.";
            return View();
        }

        public IActionResult Contact()
        {
            // İletişim sayfası
            ViewData["Message"] = "Bizimle iletişime geçin.";
            return View();
        }
    }
}
