namespace OnlineCourse.Repository
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
