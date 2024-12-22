using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Views.Home.Components._HomeCourseCategoryComponent
{
    public class _HomeCourseCategoryComponent: ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _client.GetFromJsonAsync<List<CourseCategoryDto>>("courseCategory/getActiveCategory");
            return View(response);
        }
    }
}
