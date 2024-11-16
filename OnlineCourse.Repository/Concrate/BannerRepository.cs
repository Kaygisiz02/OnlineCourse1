namespace OnlineCourse.Repository
{
    public class BannerRepository : BaseRepository<Banner>, IBannerRepository
    {
        public BannerRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
