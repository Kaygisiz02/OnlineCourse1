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
            var subscriber = _subscribeService.GetSubscribeById(id);
            return Ok(subscriber);
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
            _subscribeService.UpdateSubscribe(subscribeDto);
            return Ok("Abonelik Bilgisi Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _subscribeService.DeleteSubscribe(id);
            return Ok("Abonelik Bilgisi Silindi");
        }
    }

}
