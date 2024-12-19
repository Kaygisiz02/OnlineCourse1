
namespace OnlineCourse.Repository
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        private readonly OnlineCourseDbContext _context;
        public BlogRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public List<Blog> GetBlogWithCategories()
        {
           return _context.Blogs.Include(x=>x.BlogCategory).ToList();
        }
    }
}
