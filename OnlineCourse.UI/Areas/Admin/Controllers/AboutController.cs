using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;
using OnlineCourse.UI.Helper;

namespace OnlineCourse.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AboutController() : Controller
    {
        readonly HttpClient _client = HttpClientİnstansHelper.Client();
        
        public async Task<IActionResult> Index()
        {
            var value =await _client.GetFromJsonAsync <List<AboutDto>>("About");
            return View();
        }
    }
}
