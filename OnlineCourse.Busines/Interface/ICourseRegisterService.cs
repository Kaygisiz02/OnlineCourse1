namespace OnlineCourse.Busines
{
    public interface ICourseRegisterService
    {
        CourseRegisterDto GetCategoryById(int id);
        IEnumerable<CourseRegisterDto> GetAllCategories();
        bool UpdateCategory(CourseRegisterDto courseRegister);
        bool AddCategory(CourseRegisterDto courseRegister);
        bool RemovCategoty(int id);
    }
}
