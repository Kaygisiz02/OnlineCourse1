namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            var contactList = await _client.GetFromJsonAsync<List<ContactDto>>("contact");
            return View(contactList);

        }
        public async Task<IActionResult> RemoveContact(int id)
        {
            await _client.DeleteAsync($"contact/{id}");
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddContact(ContactDto contactDto)
        {
            var values = await _client.PostAsJsonAsync("contact", contactDto);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var value = await _client.GetFromJsonAsync<ContactDto>($"contact/{id}");
            return View(value);


        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(ContactDto contactDto)
        {
            await _client.PutAsJsonAsync("contact", contactDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
