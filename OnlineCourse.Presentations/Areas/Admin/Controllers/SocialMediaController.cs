namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class SocialMediaController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var socialMedia = await _client.GetFromJsonAsync<List<SocialMediaDto>>("SocialMedia");
            return View(socialMedia);

        }
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _client.DeleteAsync($"SocialMedia/{id}");
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSocialMedia(SocialMediaDto socialMediaDto)
        {
            var values = await _client.PostAsJsonAsync("SocialMedia", socialMediaDto);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var value = await _client.GetFromJsonAsync<SocialMediaDto>($"SocialMedia/{id}");
            return View(value);


        }
        [HttpPost]
        public async Task<IActionResult> UpdateSocialMedia(SocialMediaDto socialMediaDto)
        {
            await _client.PutAsJsonAsync("SocialMedia", socialMediaDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
