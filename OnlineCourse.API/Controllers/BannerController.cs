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
            return Ok(bannerId);
        }
        [HttpDelete]
        public IActionResult Remove(int id)
        {
            _bannerService.DeleteBanner(id);
            return Ok("Banner alanı silindi");
        }
        [HttpPost]
        public IActionResult Add(BannerDto banner)
        {
            var bannerAdded=_mapper.Map<BannerDto>(banner);
                _bannerService.AddBanner(bannerAdded);
            return Ok(bannerAdded);
        }
        [HttpPut]
        public IActionResult Update(BannerDto banner)
        {
            var bannerUpdate = _mapper.Map<BannerDto>(banner);
            _bannerService.UpdateBanner(bannerUpdate);
            return Ok("Banner alanı güncellendi");
        }

    }
}
