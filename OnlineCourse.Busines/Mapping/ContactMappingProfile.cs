namespace OnlineCourse.Busines
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
           CreateMap<Contact, ContactDto>().ReverseMap();
        }
    }
}
