//using Microsoft.AspNetCore.Mvc;
//using OnlineCourse.Busines;

//namespace OnlineCourse.Presentations.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    [Route("[area]/[controller]/[action]/{id?}")]
//    public class BlogCategoryController() : Controller
//    {
//        private readonly HttpClient _client = HttpClientInstance.CreateClient();
//        public async Task<IActionResult> Index()
//        {
//            var blogCategorytList = await _client.GetFromJsonAsync<List<BlogCategoryDto>>("blogcategory");
//            return View(blogCategorytList);
//        }
//        public async Task<IActionResult> RemoveAbout(int id)
//        {
//            await _client.DeleteAsync($"blogcategory/{id}");
//            return RedirectToAction(nameof(Index));
//        }
//        public IActionResult AddBlogCategory()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> AddBlogCategory(BlogCategoryDto blogCategoryDto)
//        {
//            var validator=new BlogCategoryValidators();
//            var result= await validator.ValidateAsync(blogCategoryDto);
//            if (!result.IsValid)
//            {
//                foreach (var x in result.Errors)
//                {
//                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
//                }
//                return View();
//            }
//            var values = await _client.PostAsJsonAsync("blogcategory", blogCategoryDto);
//            return RedirectToAction(nameof(Index));
//        }
//        public async Task<IActionResult> UpdateBlogCategory(int id)
//        {
//            var values = await _client.GetFromJsonAsync<BlogDto>($"blogcategory/{id}");
//            return View(values);
//        }
//        [HttpPost]
//        public async Task<IActionResult> UpdateBlogCategory(BlogCategoryDto blogCategoryDto)
//        {
//            await _client.PutAsJsonAsync("blogcategory", blogCategoryDto);
//            return RedirectToAction(nameof(Index));
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogCategoryController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            try
            {
                var blogCategoryList = await _client.GetFromJsonAsync<List<BlogCategoryDto>>("blogcategory");
                return View(blogCategoryList);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                return View("Error");
            }
        }

        public async Task<IActionResult> RemoveBlogCategory(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"blogcategory/{id}");
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
        public IActionResult AddBlogCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogCategory(BlogCategoryDto blogCategoryDto)
        {
            var validator = new BlogCategoryValidators();
            var result = await validator.ValidateAsync(blogCategoryDto);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(blogCategoryDto);
            }

            try
            {
                var response = await _client.PostAsJsonAsync("blogcategory", blogCategoryDto);
                if (!response.IsSuccessStatusCode)
                {
                    ModelState.AddModelError(string.Empty, "Ekleme işlemi başarısız oldu.");
                    return View(blogCategoryDto);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                return View(blogCategoryDto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBlogCategory(int id)
        {
            try
            {
                var blogCategory = await _client.GetFromJsonAsync<BlogCategoryDto>($"blogcategory/{id}");
                if (blogCategory == null)
                {
                    return NotFound("Blog kategorisi bulunamadı.");
                }
                return View(blogCategory);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlogCategory(BlogCategoryDto blogCategoryDto)
        {
            var validator = new BlogCategoryValidators();
            var result = await validator.ValidateAsync(blogCategoryDto);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(blogCategoryDto);
            }

            try
            {
                var response = await _client.PutAsJsonAsync("blogcategory", blogCategoryDto);
                if (!response.IsSuccessStatusCode)
                {
                    ModelState.AddModelError(string.Empty, "Güncelleme işlemi başarısız oldu.");
                    return View(blogCategoryDto);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hata: {ex.Message}");
                return View(blogCategoryDto);
            }
        }
    }
}
