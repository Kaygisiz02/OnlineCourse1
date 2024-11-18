namespace OnlineCourse.Busines
{
    public class SubscribeMappingProfile : Profile
    {
        public SubscribeMappingProfile()
        {
            CreateMap<SubscribeDto, Subscribe>().ReverseMap();
        }
    }
}
