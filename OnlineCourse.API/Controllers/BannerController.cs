namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController(IBannerService bannerService, IMapper mapper) : ControllerBase
    {
        private readonly IBannerService _bannerService=bannerService;
        private readonly IMapper _mapper=mapper;
        [HttpGet]
        public IActionResult GetAll()
        {
            var banner=_bannerService.GetAllBanners();
            return Ok(banner);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bannerId= _bannerService.GetBannerById(id);
            if (bannerId==null)
            {
                return NotFound("Banner alanı bulunamadı");
            }
            return Ok(bannerId);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove = _bannerService.DeleteBanner(id);
            if (!remove)
            {
                return NotFound("Banner alanı silinemedi veya bulunamadı");
            }
            return Ok("Banner alanı silindi");
        }
        [HttpPost]
        public IActionResult Add(BannerDto banner)
        {
            var bannerAdded=_mapper.Map<BannerDto>(banner);
                _bannerService.AddBanner(bannerAdded);
            return Ok("Yeni Banner Alanı Başarılı Bir Şekilde Eklendi");
        }
        [HttpPut]
        public IActionResult Update(BannerDto banner)
        {

            var bannerUpdate = _bannerService.UpdateBanner(banner);
            if (!bannerUpdate)
            {
                return BadRequest("Banner alanı silinemedi veya bulunamadı");
            }
            return Ok("Banner Alanı Başarılı Bir Şekilde Güncellendi");
        }

    }
}
