namespace OnlineCourse.Busines
{
    public class BannerMappingProfile:Profile
    {
        public BannerMappingProfile()
        {
            CreateMap<BannerDto, Banner>().ReverseMap();
        }
    }
}
