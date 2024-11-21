namespace OnlineCourse.Busines
{
    public class CourseMappingProfile:Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
        }
    }
}
