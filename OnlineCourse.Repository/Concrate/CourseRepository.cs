namespace OnlineCourse.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
