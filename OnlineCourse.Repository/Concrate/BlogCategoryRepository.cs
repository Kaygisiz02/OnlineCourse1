namespace OnlineCourse.Repository
{
    public class BlogCategoryRepository : BaseRepository<BlogCategory>, IBlogCategoryRepository
    {
        public BlogCategoryRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
