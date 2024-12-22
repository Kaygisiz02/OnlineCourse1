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
            try
            {
                var response = await _client.DeleteAsync($"banner/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, "Silme işlemi başarısız.");
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
            }

            return View("Error"); // Özel bir hata görünümü varsa yönlendirme yapılabilir.
        }
        public IActionResult AddBanner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBanner(BannerDto banner)
        {
            await _client.PostAsJsonAsync("banner", banner);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> UpdateBanner(int id)
        {
            try
            {
                var values = await _client.GetFromJsonAsync<BannerDto>($"banner/{id}");
                if (values == null)
                {
                    return NotFound("Güncellenecek veri bulunamadı.");
                }
                return View(values);
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
            }

            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(BannerDto bannerDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = await _client.PutAsJsonAsync("banner", bannerDto);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    ModelState.AddModelError(string.Empty, "Güncelleme işlemi başarısız.");
                }
                catch (Exception ex)
                {
                    // Loglama yapılabilir
                    ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                }
            }

            return View(bannerDto);
        }
    }
}
