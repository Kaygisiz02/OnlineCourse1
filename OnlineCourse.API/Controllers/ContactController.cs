using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            if (getById == null)
            {
                return NotFound("İletişim Alanı Bulunamadı");
            }
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
            var update=_contactService.UpdateContact(contactDto);
            if (!update)
            {
                return BadRequest("İletişim Alanı güncellenemedi");
            }
            return Ok("İletişim Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveContact(int id)
        {
            var remove=_contactService.DeleteContact(id);
            if (!remove)
            {
                return NotFound("İletişim Alanı Silinemedi veya Bulunamadı");
            }
            return Ok("İletişim Alanı Silindi");
        }
    }
}
