namespace OnlineCourse.Repository
{
    public interface ICourseCategoryRepository:IBaseRepository<CourseCategory>
    {
        void DontShowOnHome(int id);
        void ShowOnHome(int id);
    }
}
