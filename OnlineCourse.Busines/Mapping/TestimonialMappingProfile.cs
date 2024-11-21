namespace OnlineCourse.Busines
{
    public class TestimonialMappingProfile : Profile
    {
        public TestimonialMappingProfile()
        {
            CreateMap<Testimonial, TestimonialDto>().ReverseMap();
        }
    }
}
