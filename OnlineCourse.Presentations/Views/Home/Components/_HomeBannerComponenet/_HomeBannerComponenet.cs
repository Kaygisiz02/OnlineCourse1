using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations.Views.Home.Components._HomeBannerComponenet
{
    public class _HomeBannerComponenet : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _client.GetFromJsonAsync<List<BannerDto>>("banner");
            return View(response);
        }
    }
}
