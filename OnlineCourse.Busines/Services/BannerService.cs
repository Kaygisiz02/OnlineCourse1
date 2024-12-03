namespace OnlineCourse.Busines
{
    public class BannerService(IBannerRepository bannerRepository, IMapper mapper) : IBannerService
    {
        readonly IBannerRepository _bannerRepository=bannerRepository;
        readonly IMapper _mapper=mapper;
        public bool AddBanner(BannerDto bannerDto)
        {
            var banner=_mapper.Map<Banner>(bannerDto);
            return _bannerRepository.Add(banner);
        }

        public bool DeleteBanner(int id)
        {
            return _bannerRepository.Remove(id);
        }

        public List<BannerDto> GetAllBanners()
        {
            var bannerGetAll= _bannerRepository.GetAll();
            return _mapper.Map<List<BannerDto>>(bannerGetAll);
        }

        public BannerDto GetBannerById(int id)
        {
            var bannerId= _bannerRepository.Get(id);
            return _mapper.Map<BannerDto>(bannerId);
        }

        public bool UpdateBanner(BannerDto bannerDto)
        {
            var banner=_bannerRepository.Get(bannerDto.BannerId);
            if(banner == null)
            {
                return false;
            }
            _mapper.Map(bannerDto, banner);
            return _bannerRepository.Update(banner);

        }
    }
}
