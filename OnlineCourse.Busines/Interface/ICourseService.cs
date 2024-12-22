using System.Linq.Expressions;

namespace OnlineCourse.Busines
{
    public interface ICourseService
    {
        CourseDto GetCourseById(int id);
        IEnumerable<CourseDto> GetAllCourse();
        IEnumerable<CourseDto> GetAllCourse(Expression<Func<CourseDto, bool>> predicate);
        bool  AddCourse(CourseDto courseDto);
        bool UpdateCourse(CourseDto courseDto);
        bool DeleteCourse(int id);
        void TDontShowOnHome(int id);
        void TShowOnHome(int id);

    }
}
