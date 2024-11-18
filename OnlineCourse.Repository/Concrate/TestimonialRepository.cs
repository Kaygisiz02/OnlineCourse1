using OnlineCourse.Repository.Abstract;

namespace OnlineCourse.Repository
{
    public class TestimonialRepository : BaseRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
