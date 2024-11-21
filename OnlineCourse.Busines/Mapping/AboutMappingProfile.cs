namespace OnlineCourse.Busines
{
    public class AboutMappingProfile:Profile
    {
        public AboutMappingProfile()
        {
           CreateMap<About, AboutDto>().ReverseMap();
        }
    }   
}
