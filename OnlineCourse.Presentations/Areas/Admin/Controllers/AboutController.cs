using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AboutController() : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var value = await _client.GetFromJsonAsync<List<AboutDto>>("abouts");
            return View(value);
        }
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _client.DeleteAsync($"abouts/{id}");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAbout(AboutDto aboutDto)
        {
             await _client.PostAsJsonAsync("abouts/", aboutDto);
            return RedirectToAction(nameof(Index));
            
        }
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var values = await _client.GetFromJsonAsync<AboutDto>($"abouts/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(AboutDto aboutDto)
        {
           await _client.PutAsJsonAsync("abouts", aboutDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
