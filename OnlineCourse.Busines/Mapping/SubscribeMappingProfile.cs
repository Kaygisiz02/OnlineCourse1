namespace OnlineCourse.Busines
{
    public class SubscribeMappingProfile : Profile
    {
        public SubscribeMappingProfile()
        {
            CreateMap<Subscribe, SubscribeDto>().ReverseMap();
        }
    }
}
