using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogCategoryController() : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var value = await _client.GetFromJsonAsync<List<BlogCategoryDto>>("blogcategory");
            return View(value);
        }
        public async Task<IActionResult> RemoveBlogCategory(int id)
        {
            await _client.DeleteAsync($"blogcategory/{id}");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddBlogCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlogCategory(BlogCategoryDto blogCategoryDto)
        {
            var validator=new BlogCategoryValidators();
            var result= await validator.ValidateAsync(blogCategoryDto);
            if (!result.IsValid)
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();

            }
            
            await _client.PostAsJsonAsync("blogcategory/", blogCategoryDto);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> UpdateBlogCategory(int id)
        {
            var values = await _client.GetFromJsonAsync<BlogCategoryDto>($"blogcategory/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlogCategory(BlogCategoryDto blogCategoryDto)
        {
            await _client.PutAsJsonAsync("blogcategory", blogCategoryDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
