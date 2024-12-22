using System.Linq.Expressions;

namespace OnlineCourse.Busines
{
    public interface ICourseCategoryService
    {
        CourseCategoryDto GetCourseCategoryById(int id);
        List<CourseCategoryDto> GetAllCourseCategory();
        List<CourseCategoryDto> GetAllFiltered(Expression<Func<CourseCategory, bool>> predicate);
        bool AddCourseCategory(CourseCategoryDto courseCategory);
        bool UpdateCourseCategory(CourseCategoryDto courseCategory);
        bool RemoveCourseCategory(int id);
        void TDontShowOnHome(int id);
        void TShowOnHome(int id);

    }
}
