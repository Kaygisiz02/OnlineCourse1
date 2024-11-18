using OnlineCourse.Repository;

namespace OnlineCourse.Busines
{
    public class SocialMediaServices(ISocialMediaRepository socialMediaRepository, IMapper mapper) : ISocialMediaService
    {
        readonly ISocialMediaRepository _socialMediaRepository = socialMediaRepository;
        readonly IMapper _mapper = mapper;
        public bool AddSocialMedia(SocialMediaDto socialMediaDto)
        {
            var addedSocialMedia = _mapper.Map<SocialMedia>(socialMediaDto);
            return _socialMediaRepository.Add(addedSocialMedia);

        }

        public bool DeleteSocialMedia(int id)
        {
            return _socialMediaRepository.Remove(id);
        }

        public IEnumerable<SocialMediaDto> GetAllSocialMedia()
        {
            var getAllSocialMedia = _socialMediaRepository.GetAll();
            return _mapper.Map<IEnumerable<SocialMediaDto>>(getAllSocialMedia);
        }

        public SocialMediaDto GetSocialMediaById(int id)
        {
            var getById = _socialMediaRepository.Get(id);
            return _mapper.Map<SocialMediaDto>(getById);
        }

        public bool UpdateSocialMedia(SocialMediaDto socialMediaDto)
        {
            var socialMediaUpdate = _socialMediaRepository.Get(socialMediaDto.SocialMediaId);
            if (socialMediaUpdate == null)
            {
                return false;
            }
            _mapper.Map(socialMediaDto, socialMediaUpdate);
            return _socialMediaRepository.Update(socialMediaUpdate);
        }
    }
}
