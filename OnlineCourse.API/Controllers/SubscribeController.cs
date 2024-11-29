namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController(ISubscribeService subscribeService) : ControllerBase
    {
        readonly ISubscribeService _subscribeService = subscribeService;

        [HttpGet]
        public IActionResult GetAll()
        {
            var subscribers = _subscribeService.GetAllSubscribe();
            return Ok(subscribers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById = _subscribeService.GetSubscribeById(id);
            if (getById == null)
            {
                return NotFound("Abonelik Alanı Bulunamadı");
            }
            return Ok(getById);
        }

        [HttpPost]
        public IActionResult Add(SubscribeDto subscribeDto)
        {
            var addedSubscriber = _subscribeService.AddSubscribe(subscribeDto);
            return Ok(addedSubscriber);
        }

        [HttpPut]
        public IActionResult Update(SubscribeDto subscribeDto)
        {
            var update=_subscribeService.UpdateSubscribe(subscribeDto);
            if (!update)
            {
                return BadRequest("Abonelik bilgisi güncellenemedi");
            }
            return Ok("Abonelik Bilgisi Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_subscribeService.DeleteSubscribe(id);
            if (!remove)
            {
                return NotFound("Abonelik Alanı Silinemdi veya Bulunamadı");
            }
            return Ok("Abonelik Bilgisi Silindi");
        }
    }

}
