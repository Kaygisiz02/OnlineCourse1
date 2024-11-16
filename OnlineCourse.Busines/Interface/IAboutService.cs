namespace OnlineCourse.Busines
{
    public interface IAboutService
    {
        AboutDto GetAboutById(int id);
        List<AboutDto> GetAllAbouts();
        bool AddAbout(AboutDto aboutDto);
        bool UpdateAbout(AboutDto aboutDto);
        bool DeleteAbout(int id);
    }  
}
