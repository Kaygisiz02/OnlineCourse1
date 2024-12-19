namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CourseCategoryController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var aboutList = await _client.GetFromJsonAsync<List<CourseCategoryDto>>("courseCategory");
            return View(aboutList);

        }
        public async Task<IActionResult> RemoveCourseCategory(int id)
        {
            await _client.DeleteAsync($"courseCategory/{id}");
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult AddCourseCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCourseCategory(CourseCategoryDto courseCategoryDto)
        {
            var values = await _client.PostAsJsonAsync("CourseCategory", courseCategoryDto);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> UpdateCourseCategory(int id)
        {
            var value = await _client.GetFromJsonAsync<CourseCategoryDto>($"CourseCategory/{id}");
            return View(value);


        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourseCategory(CourseCategoryDto courseCategoryDto)
        {
            await _client.PutAsJsonAsync("courseCategory", courseCategoryDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DontShowOnHome(int id)
        {
            await _client.GetAsync("coursecategory/DontShowOnHome/" + id);
            return RedirectToAction("Index");
        }
    }
}
