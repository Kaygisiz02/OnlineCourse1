using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Busines
{
    public class SocialMediaServices(ISocialMediaRepository socialMediaRepository,IMapper mapper) : ISocialMediaService
    {
        private readonly ISocialMediaRepository _socialMediaRepository=socialMediaRepository;
        private readonly IMapper _mapper=mapper;
        public bool AddSocialMedia(SocialMediaDto socialMediaDto)
        {
            var socialMediaAdd = _mapper.Map<SocialMedia>(socialMediaDto);
            return _socialMediaRepository.Add(socialMediaAdd);
        }

        public bool DeleteMessage(int id)
        {
           return _socialMediaRepository.Remove(id);
        }

        public IEnumerable<SocialMediaDto> GetAllSocialMedia()
        {
            var getAll= _socialMediaRepository.GetAll();
            return _mapper.Map<List<SocialMediaDto>>(getAll);
        }

        public SocialMediaDto GetSocialMediaById(int id)
        {
            var getById=_socialMediaRepository.Get(id);
            return _mapper.Map<SocialMediaDto>(getById);
        }

        public bool UpdateSocialMedia(SocialMediaDto socialMediaDto)
        {
            var socialMediaUpdate = _socialMediaRepository.Get(socialMediaDto.SocialMediaId);
            if (socialMediaUpdate == null)
            {
                return false;
            }
            _mapper.Map(socialMediaUpdate, socialMediaDto);
            return _socialMediaRepository.Update(socialMediaUpdate);
        }
    }
}
