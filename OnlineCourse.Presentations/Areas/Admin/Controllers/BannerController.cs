using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BannerController() : Controller
    {
        private readonly HttpClient _client=HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {

            try
            {
                var bannerList = await _client.GetFromJsonAsync<List<BannerDto>>("banner");
                return View(bannerList);
            }
            catch (Exception ex)
            {
                var res = ex.Message;
                throw;
            }
        }
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _client.DeleteAsync($"baner/{id}");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddBanner()
        {
            return View();
        }
        public async Task<IActionResult> AddBanner(BannerDto banner)
        {
            await _client.PostAsJsonAsync("banner", banner);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> UpdateBanner(int id)
        {
            var values =await _client.GetFromJsonAsync<BannerDto>($"banner/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(BannerDto bannerDto)
        {
            await _client.PutAsJsonAsync<BannerDto>("banner",bannerDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
