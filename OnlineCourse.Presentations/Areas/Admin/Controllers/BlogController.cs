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
            //var aboutList = await _client.GetFromJsonAsync<List<BlogDto>>("blog");
            //return View(aboutList);
            try
            {
                var blogList = await _client.GetFromJsonAsync<List<BlogDto>>("blog");
                return View(blogList);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                return View("Error");
            }
        }
        public  async Task<IActionResult> RemoveAbout(int id)
        {
            //await _client.DeleteAsync($"blog/{id}");
            //return RedirectToAction(nameof(Index));
            try
            {
                var response = await _client.DeleteAsync($"blog/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    ModelState.AddModelError(string.Empty, "Silme işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
            }

            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(BlogDto blogDto)
        {
            //var values= await _client.PostAsJsonAsync("blog",blogDto);
            //return RedirectToAction(nameof(Index));
            if (ModelState.IsValid)
            {
                try
                {
                    var response = await _client.PostAsJsonAsync("blog", blogDto);
                    if (!response.IsSuccessStatusCode)
                    {
                        ModelState.AddModelError(string.Empty, "Ekleme işlemi başarısız oldu.");
                        return View(blogDto);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                    return View(blogDto);
                }

                return RedirectToAction(nameof(Index));
            }

            return View(blogDto);
        }
        public async Task<IActionResult> UpdateBlog(int id)
        {
            //var values = await _client.GetFromJsonAsync<BlogDto>($"blog/{id}");
            //return View(values);
            try
            {
                var blog = await _client.GetFromJsonAsync<BlogDto>($"blog/{id}");
                if (blog == null)
                {
                    return NotFound("Blog bulunamadı.");
                }
                return View(blog);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                return View("Error");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(BlogDto blogDto)
        {
            //await _client.PutAsJsonAsync("blog", blogDto);
            //return RedirectToAction(nameof(Index));
            if (ModelState.IsValid)
            {
                try
                {
                    var response = await _client.PutAsJsonAsync("blog", blogDto);
                    if (!response.IsSuccessStatusCode)
                    {
                        ModelState.AddModelError(string.Empty, "Güncelleme işlemi başarısız oldu.");
                        return View(blogDto);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                    return View(blogDto);
                }

                return RedirectToAction(nameof(Index));
            }

            return View(blogDto);
        }
    }
}
