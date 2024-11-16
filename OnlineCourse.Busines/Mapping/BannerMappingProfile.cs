namespace OnlineCourse.Busines.Mapping
{
    public class BannerMappingProfile:Profile
    {
        public BannerMappingProfile()
        {
            CreateMap<BannerDto, Banner>().ReverseMap();
        }
    }
}
