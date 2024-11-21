using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Entity;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController(ISubscribeService subscribeService) : ControllerBase
    {
        private readonly ISubscribeService _subscribeService=subscribeService;
        [HttpGet]
        public IActionResult GetAll()
        {
            var subscribeGetAll = _subscribeService.GetAllSubscribe();
            return Ok(subscribeGetAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById = _subscribeService.GetSubscribeById(id);
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult Addsubscribe(SubscribeDto subscribeDto)
        {
            var subscribeAdded = _subscribeService.AddSubscribe(subscribeDto);
            return Ok(subscribeAdded);
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(SubscribeDto subscribeDto)
        {
            _subscribeService.UpdateSubscribe(subscribeDto);
            return Ok("Abone Alanı Güncellendi");
        }
        [HttpDelete]
        public IActionResult RemoveSubscribe(int id)
        {
            _subscribeService.DeleteSubscribe(id);
            return Ok("Abone Alanı Silindi");
        }
    }
}
