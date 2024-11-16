namespace OnlineCourse.Busines
{
    public interface IMessageService
    {
        MessageDto GetMessageById(int id);
        IEnumerable<MessageDto> GetAllMessage();
        bool AddMessage(MessageDto messageDto);
        bool UpdateMessage(MessageDto messageDto);
        bool DeleteMessage(int id);
    }
}
