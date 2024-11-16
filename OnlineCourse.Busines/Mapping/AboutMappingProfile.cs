namespace OnlineCourse.Busines
{
    public class AboutMappingProfile:Profile
    {
        public AboutMappingProfile()
        {
           CreateMap<AboutDto, About>().ReverseMap();
        }
    }   
}
