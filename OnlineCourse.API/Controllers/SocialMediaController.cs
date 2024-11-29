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
            var getById = _socialMediaService.GetSocialMediaById(id);
            if (getById == null)
            {
                return NotFound("Social Medya Alanı Bulunamadı");
            }
            return Ok(getById);
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
            var update=_socialMediaService.UpdateSocialMedia(socialMediaDto);
            if (!update)
            {
                return BadRequest("Sosyal Meya Alanı Güncellenemedi");
            }
            return Ok("Sosyal Medya Alanı Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_socialMediaService.DeleteSocialMedia(id);
            if (!remove)
            {
                return NotFound("Sosyal Medya Alanı Silinemedi veya Bulunamadı");
            }
            return Ok("Sosyal Medya Alanı Silindi");
        }
    }

}
