namespace OnlineCourse.Repository
{
    public class AboutRepository : BaseRepository<About>, IAboutRepository
    {
        public AboutRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    } 
}
