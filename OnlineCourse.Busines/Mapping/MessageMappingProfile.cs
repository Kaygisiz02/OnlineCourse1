namespace OnlineCourse.Busines
{
    public class MessageMappingProfile : Profile
    {
        public MessageMappingProfile()
        {
            CreateMap<MessageDto, Message>().ReverseMap();
        }
    }
}
