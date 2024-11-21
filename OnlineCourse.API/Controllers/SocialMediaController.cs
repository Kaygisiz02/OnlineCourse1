using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController(ISocialMediaService socialMediaService) : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService=socialMediaService;
        [HttpGet]
        public IActionResult GetAll()
        {
            var socialMediaGetAll = _socialMediaService.GetAllSocialMedia();
            return Ok(socialMediaGetAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById = _socialMediaService.GetSocialMediaById(id);
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMediaDto socialMediaDto)
        {
            var socialMediaAdded = _socialMediaService.AddSocialMedia(socialMediaDto);
            return Ok(socialMediaAdded);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(SocialMediaDto socialMediaDto)
        {
            _socialMediaService.UpdateSocialMedia(socialMediaDto);
            return Ok("Sosyal Medya Alanı Güncellendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            _socialMediaService.DeleteMessage(id);
            return Ok("Sosyal Medya Alanı Silindi");
        }
    }
}
