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
            _aboutService.UpdateAbout(about);
            return Ok("Hakkımızda alanı güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _aboutService.DeleteAbout(id);
            return Ok("Hakkımda Alanı Silindi");
        }
    }
}
