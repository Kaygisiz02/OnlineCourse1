
namespace OnlineCourse.Repository
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        private readonly OnlineCourseDbContext _dbContext;
        public BlogRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Blog> GetBlogsWithCategories()
        {
           return _dbContext.Blogs.Include(
               x=>x.BlogCategory).ToList();
        }
    }
}
