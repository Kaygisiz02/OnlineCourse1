using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;
namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var aboutList = await _client.GetFromJsonAsync<List<AboutDto>>("blog");
            return View(aboutList);
        }
        public  async Task<IActionResult> RemoveAbout(int id)
        {
            await _client.DeleteAsync($"blog/{id}");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(BlogDto blogDto)
        {
            var values= await _client.PostAsJsonAsync("blog",blogDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var values = await _client.GetFromJsonAsync<BlogDto>($"blog/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(BlogDto blogDto)
        {
            await _client.PutAsJsonAsync("blog", blogDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
