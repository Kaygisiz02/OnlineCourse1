namespace OnlineCourse.Busines
{
    public interface ICourseCategoryService
    {
        CourseCategoryDto GetCourseCategoryById(int id);
        IEnumerable<CourseCategoryDto> GetAllCourseCategory();
        bool AddCourseCategory(CourseCategoryDto courseCategory);
        bool UpdateCourseCategory(CourseCategoryDto courseCategory);
        bool RemoveCourseCategory(int id);


    }
}
