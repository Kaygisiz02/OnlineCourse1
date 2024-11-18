namespace OnlineCourse.Repository
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        public MessageRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }   
}
