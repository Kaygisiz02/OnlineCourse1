using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CourseController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task CourseCategoryDropDown()
        {
            var courseCategoryList = await _client.GetFromJsonAsync<List<CourseCategoryDto>>("courseCategory");
            List<SelectListItem> courseCategories = (from x in courseCategoryList
                                         select new SelectListItem
                                         {
                                             Text=x.CourseCategoryName,
                                             Value=x.CourseCategoryId.ToString(),
                                         }).ToList();
            ViewBag.courseCategories = courseCategories;
        }
        public async Task<IActionResult> Index()
        {
            var aboutList = await _client.GetFromJsonAsync<List<CourseDto>>("Course");
            return View(aboutList);

        }
        public async Task<IActionResult> RemoveCourse(int id)
        {
            await _client.DeleteAsync($"Course/{id}");
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> AddCourse()
        {
           await CourseCategoryDropDown();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCourse(CourseDto courseDto)
        {
            var values = await _client.PostAsJsonAsync("Course", courseDto);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> UpdateCourse(int id)
        {
           await CourseCategoryDropDown();
            var value = await _client.GetFromJsonAsync<CourseDto>($"Course/{id}");
            return View(value);


        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourse(CourseDto courseDto)
        {
            await _client.PutAsJsonAsync("Course", courseDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ShowOnHome(int id)
        {
            await _client.GetAsync("Course/ShowOnHome/" + id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DontShowOnHome(int id)
        {
            await _client.GetAsync("Course/DontShowOnHome/" + id);
            return RedirectToAction("Index");
        }
    }
}
