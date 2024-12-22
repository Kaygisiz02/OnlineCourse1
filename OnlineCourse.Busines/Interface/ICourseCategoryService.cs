using System.Linq.Expressions;

namespace OnlineCourse.Busines
{
    public interface ICourseCategoryService
    {
        CourseCategoryDto GetCourseCategoryById(int id);
        IEnumerable<CourseCategoryDto> GetAllCourseCategory();
        IEnumerable<CourseCategoryDto> GetFiterCourseCategory(Expression<Func<CourseCategoryDto, bool>> predicate);
        bool AddCourseCategory(CourseCategoryDto courseCategory);
        bool UpdateCourseCategory(CourseCategoryDto courseCategory);
        bool RemoveCourseCategory(int id);
        void TDontShowOnHome(int id);
        void TShowOnHome(int id);
    }
}
