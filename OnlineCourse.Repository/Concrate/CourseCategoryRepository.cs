namespace OnlineCourse.Repository
{
    public class CourseCategoryRepository : BaseRepository<CourseCategory>,ICourseCategoryRepository 
    {
        public CourseCategoryRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
