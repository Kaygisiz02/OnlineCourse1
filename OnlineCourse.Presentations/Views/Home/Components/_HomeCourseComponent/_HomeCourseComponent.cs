using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Views.Home.Components._HomeCourseComponent
{
    public class _HomeCourseComponent : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _client.GetFromJsonAsync<List<CourseDto>>("course/GetActiveCourse");
            return View(response);
        }
    }
}
