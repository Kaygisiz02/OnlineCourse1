namespace OnlineCourse.Busines
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
           CreateMap<ContactDto, Contact>().ReverseMap();
        }
    }
}
