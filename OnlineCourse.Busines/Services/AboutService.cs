namespace OnlineCourse.Busines
{
    public class AboutService(IAboutRepository aboutRepository,IMapper mapper) : IAboutService
    {
        private readonly IAboutRepository _aboutRepository=aboutRepository;
        private readonly IMapper _mapper=mapper;

        public bool AddAbout(AboutDto aboutDto)
        {
            var about = _mapper.Map<About>(aboutDto);
            return _aboutRepository.Add(about);
        }


        public bool DeleteAbout(int id)
        {
            return _aboutRepository.Remove(id);
        }


        public AboutDto GetAboutById(int id)
        {
            var about= _aboutRepository.Get(id);
            return _mapper.Map<AboutDto>(about);
        }

        public List<AboutDto> GetAllAbouts()
        {
            var about = _aboutRepository.GetAll();
            return _mapper.Map<List<AboutDto>>(about);

        }


        public bool UpdateAbout(AboutDto aboutDto)
        {
            var about = _aboutRepository.Get(aboutDto.AboutId);
            if (about == null)
            {
                return false;
            }
            _mapper.Map(aboutDto, about);
            return _aboutRepository.Update(about);
        }
    }
}
