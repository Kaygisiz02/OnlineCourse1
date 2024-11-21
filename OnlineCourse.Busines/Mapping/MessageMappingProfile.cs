namespace OnlineCourse.Busines
{
    public class MessageMappingProfile : Profile
    {
        public MessageMappingProfile()
        {
            CreateMap<Message, MessageDto>().ReverseMap();
        }
    }
}
