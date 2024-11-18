namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController(ISocialMediaService socialMediaService) : ControllerBase
    {
        readonly ISocialMediaService _socialMediaService = socialMediaService;

        [HttpGet]
        public IActionResult GetAll()
        {
            var socialMediaList = _socialMediaService.GetAllSocialMedia();
            return Ok(socialMediaList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var socialMedia = _socialMediaService.GetSocialMediaById(id);
            return Ok(socialMedia);
        }

        [HttpPost]
        public IActionResult Add(SocialMediaDto socialMediaDto)
        {
            var addedSocialMedia = _socialMediaService.AddSocialMedia(socialMediaDto);
            return Ok(addedSocialMedia);
        }

        [HttpPut]
        public IActionResult Update(SocialMediaDto socialMediaDto)
        {
            _socialMediaService.UpdateSocialMedia(socialMediaDto);
            return Ok("Sosyal Medya Alanı Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _socialMediaService.DeleteSocialMedia(id);
            return Ok("Sosyal Medya Alanı Silindi");
        }
    }

}
