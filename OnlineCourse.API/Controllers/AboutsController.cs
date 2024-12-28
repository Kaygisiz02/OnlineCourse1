namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService aboutService, IMapper mapper) : ControllerBase
    {
        private readonly IAboutService _aboutService = aboutService;
        private readonly IMapper _mapper = mapper;
        [HttpGet]
        public IActionResult GetAll()
        {
            var about = _aboutService.GetAllAbouts();
            return Ok(about);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var aboutId= _aboutService.GetAboutById(id);
            if (aboutId == null)
            {
                return NotFound("Hakkında alanı bulunamadı");
            }
            return Ok(aboutId);
        }
   
        [HttpPost]
        
        public IActionResult Add(AboutDto about)
        {
            var added= _aboutService.AddAbout(about);
            return Ok(added);
        }
        [HttpPut]
        public IActionResult Update(AboutDto about)
        {
            var updated = _aboutService.UpdateAbout(about);
            if (!updated)
            {
                return BadRequest("Hakkımızda alanı güncellenemedi");
            }
            return Ok("Hakkımızda alanı güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var deleted = _aboutService.DeleteAbout(id);
            if (!deleted)
            {
                return NotFound("Hakkımda alanı silinemedi veya bulunamadı");
            }
            return Ok("Hakkımda Alanı Silindi");
        }
    }
}
