namespace OnlineCourse.Repository
{
    public class CourseRegisterRepository : BaseRepository<CourseRegister>, ICourseRegisterRepository
    {
        public CourseRegisterRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
