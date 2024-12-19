using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Presentations.Models;
using System.Diagnostics;

namespace OnlineCourse.Presentations.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
