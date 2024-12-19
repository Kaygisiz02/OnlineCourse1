namespace OnlineCourse.Repository
{
  
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        private readonly OnlineCourseDbContext _context;
        public CourseRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public void DontShowOnHome(int id)
        {
            var values = _context.Courses.Find(id);
            values.IsShown = false;
            _context.SaveChanges();
        }
        public void ShowOnHome(int id)
        {
            var values = _context.Courses.Find(id);
            values.IsShown = true;
            _context.SaveChanges();
        }
    }
}
