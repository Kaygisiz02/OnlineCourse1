using OnlineCourse.Busines;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController(IMessageService messageService) : ControllerBase
    {
        readonly IMessageService _messageService=messageService;
        [HttpGet]
        public IActionResult GetAll()
        {
            var messageGetAll = _messageService.GetAllMessage();
            return Ok(messageGetAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById = _messageService.GetMessageById(id);
            if (getById == null)
            {
                return NotFound("Mesaj Alanı Bulunamadı");
            }
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult AddCourse(MessageDto mesageDto)
        {
            var messageAdded = _messageService.AddMessage(mesageDto);
            return Ok(messageAdded);
        }
        [HttpPut]
        public IActionResult UpdateMessage(MessageDto messageDto)
        {
            var update=_messageService.UpdateMessage(messageDto);
            if (!update)
            {
                return BadRequest("Mesaj Alanı güncellenemedi");
            }
            return Ok("Mesaj Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveMessage(int id)
        {
            var remove=_messageService.DeleteMessage(id);
            if (!remove)
            {
                return NotFound("Mesaj Alanı Silinemedi veya Bulunamadı");
            }
            return Ok("Mesaj Alanı Silindi");
        }
    }
}
