namespace OnlineCourse.Busines
{
    public interface ITestimonialService
    {
        TestimonialDto GetTestimonialById(int id);
        IEnumerable<TestimonialDto> GetAllTestimonial();
        bool AddTestimonial(TestimonialDto testimonialDto);
        bool UpdateTestimonial(TestimonialDto testimonialDto);
        bool DeleteTestimonial(int id);
    }
}
