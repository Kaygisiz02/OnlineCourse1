namespace OnlineCourse.Busines
{
    public interface ICourseService
    {
        CourseDto GetCourseById(int id);
        IEnumerable<CourseDto> GetAllCourse();
        bool  AddCourse(CourseDto courseDto);
        bool UpdateCourse(CourseDto courseDto);
        bool DeleteCourse(int id);
        void TDontShowOnHome(int id);
        void TShowOnHome(int id);

    }
}
