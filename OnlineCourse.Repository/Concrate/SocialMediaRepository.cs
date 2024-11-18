namespace OnlineCourse.Repository
{
    public class SocialMediaRepository : BaseRepository<SocialMedia>,ISocialMediaRepository
    {
        public SocialMediaRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }  
}
