namespace OnlineCourse.Repository
{
    public class SubscribeRepository : BaseRepository<Subscribe>, ISubscribeRepository
    {
        public SubscribeRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
