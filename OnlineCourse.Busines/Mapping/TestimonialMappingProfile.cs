namespace OnlineCourse.Busines
{
    public class TestimonialMappingProfile : Profile
    {
        public TestimonialMappingProfile()
        {
            CreateMap<TestimonialDto, Testimonial>().ReverseMap();
        }
    }
}
