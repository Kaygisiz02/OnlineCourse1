namespace OnlineCourse.Presentations.Views.Home.Components._HomeCourseComponentComponent
{
    public class _HomeCourseComponentComponent:ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _client.GetFromJsonAsync<List<CourseDto>>("course/GetActiveCourses");
            return View(response);
        }
    }
}
