namespace OnlineCourse.Repository
{
    public interface ICourseRepository:IBaseRepository<Course>
    {
        void DontShowOnHome(int id);
        void ShowOnHome(int id);
    }
}
