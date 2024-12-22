using System.Linq.Expressions;

namespace OnlineCourse.Busines
{
    public interface ICourseService
    {
        CourseDto GetCourseById(int id);
        List<CourseDto> GetAllCourse();
        List<CourseDto> GetAllFiltered(Expression<Func<Course, bool>> predicate);
        bool  AddCourse(CourseDto courseDto);
        bool UpdateCourse(CourseDto courseDto);
        bool DeleteCourse(int id);
        void TDontShowOnHome(int id);
        void TShowOnHome(int id);

    }
}
