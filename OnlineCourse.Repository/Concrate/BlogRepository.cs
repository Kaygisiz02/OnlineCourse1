namespace OnlineCourse.Repository
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        public BlogRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
