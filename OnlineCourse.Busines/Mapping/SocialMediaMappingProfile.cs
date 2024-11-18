namespace OnlineCourse.Busines
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {
            CreateMap<SocialMediaDto, SocialMedia>().ReverseMap();
        }
    }  
}
