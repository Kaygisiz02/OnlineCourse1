namespace OnlineCourse.Busines
{
    public interface ISubscribeService
    {
        SubscribeDto GetSubscribeById(int id);
        IEnumerable<SubscribeDto> GetAllSubscribe();
        bool AddSubscribe(SubscribeDto subscribeDto);
        bool UpdateSubscribe(SubscribeDto subscribeDto);
        bool DeleteSubscribe(int id);
    } 
}
