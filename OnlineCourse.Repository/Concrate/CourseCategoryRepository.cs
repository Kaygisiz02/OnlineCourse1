namespace OnlineCourse.Repository
{
    public class CourseCategoryRepository : BaseRepository<CourseCategory>,ICourseCategoryRepository 
    {
        private readonly OnlineCourseDbContext _context;
        public CourseCategoryRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public void DontShowOnHome(int id)
        {
            var values = _context.CourseCategories.Find(id);
            values.IsShown = false;
            _context.SaveChanges();
        }
        public void ShowOnHome(int id)
        {
            var values = _context.CourseCategories.Find(id);
            values.IsShown = true;
            _context.SaveChanges();
        }
    }
}
