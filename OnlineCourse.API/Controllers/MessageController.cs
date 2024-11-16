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
            _messageService.UpdateMessage(messageDto);
            return Ok("Kurs Alanı Güncellendi");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            _messageService.DeleteMessage(id);
            return Ok("Kurse Alanı Silindi");
        }
    }
}
