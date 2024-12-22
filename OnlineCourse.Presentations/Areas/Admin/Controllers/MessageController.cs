using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Busines;
using OnlineCourse.Presentations;

namespace OnlineMessage.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var messageList = await _client.GetFromJsonAsync<List<MessageDto>>("Message");
            return View(messageList);

        }
        public async Task<IActionResult> RemoveMessage(int id)
        {
            await _client.DeleteAsync($"Message/{id}");
            return RedirectToAction(nameof(Index));

        }
      
        [HttpGet]
        public async Task<IActionResult> MessageDetail(int id)
        {
            var value = await _client.GetFromJsonAsync<MessageDto>($"Message/{id}");
            return View(value);


        }
      
    }
}
