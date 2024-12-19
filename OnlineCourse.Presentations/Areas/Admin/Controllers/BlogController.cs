using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineCourse.Busines;
namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        public async Task CategoryDropDown()
        {
            var categoryList = await _client.GetFromJsonAsync<List<BlogCategoryDto>>("blogcategory");
            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text=x.BlogCategoryName,
                                                   Value=x.BlogCategoryId.ToString(),
                                               }).ToList();
            ViewBag.categories = categories;
        }
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task CategoryDropDown()
        {
            var categoryList = await _client.GetFromJsonAsync<List<BlogCategoryDto>>("blogCategory");
            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.BlogCategoryName,
                                                   Value = x.BlogCategoryId.ToString(),
                                                   
                                               }).ToList();
            ViewBag.category = categories;
        }
        public async Task<IActionResult> Index()
        {
            var aboutList = await _client.GetFromJsonAsync<List<BlogDto>>("blog");
            return View(aboutList);

        }
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _client.DeleteAsync($"blog/{id}");
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> AddBlog()
        {
            await CategoryDropDown();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(BlogDto blogDto)
        {
            var values = await _client.PostAsJsonAsync("blog", blogDto);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            await CategoryDropDown();

        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(BlogDto blogDto)
        {
            await _client.PutAsJsonAsync("blog", blogDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
