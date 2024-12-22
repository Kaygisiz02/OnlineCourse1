namespace OnlineCourse.Busines
{
    public interface ICourseRegisterService
    {
        CourseRegisterDto GetCategoryById(int id);
        IEnumerable<CourseRegisterDto> GetAllCategories();
        bool UpdateCategory(CourseRegisterDto category);
        bool AddCategory(CourseRegisterDto category);
        bool RemovCategoty(int id);
    }
}
