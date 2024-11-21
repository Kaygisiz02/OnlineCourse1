namespace OnlineCourse.Busines
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {
            CreateMap<SocialMedia, SocialMediaDto>().ReverseMap();
        }
    }
}
