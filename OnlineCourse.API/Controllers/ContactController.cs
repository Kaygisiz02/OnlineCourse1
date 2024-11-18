namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(IContactService contactService) : ControllerBase
    {
        readonly IContactService _contactService=contactService;
        [HttpGet]
        public IActionResult GetAll()
        {
            var conatcatGetAll = _contactService.GetAllContacts();
            return Ok(conatcatGetAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById = _contactService.GetContactById(id);
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult AddCountact(ContactDto contactDto)
        {
            var contactAdded = _contactService.AddContact(contactDto);
            return Ok(contactAdded);
        }
        [HttpPut]
        public IActionResult UpdateCountact(ContactDto contactDto)
        {
            _contactService.UpdateContact(contactDto);
            return Ok("Kurs Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveContact(int id)
        {
            _contactService.DeleteContact(id);
            return Ok("Kurse Alanı Silindi");
        }
    }
}
