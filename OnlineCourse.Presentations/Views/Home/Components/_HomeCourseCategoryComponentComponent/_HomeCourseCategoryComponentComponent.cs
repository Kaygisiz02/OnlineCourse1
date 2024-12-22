namespace OnlineCourse.Presentations.Views.Home.Components._HomeCourseCategoryComponentComponent
{
    public class _HomeCourseCategoryComponentComponent:ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _client.GetFromJsonAsync<List<CourseCategoryDto>>("courseCategory/GetActiveCategories");
            return View(response);
        }
    }
}
