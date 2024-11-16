namespace OnlineCourse.Busines
{
    public class CourseMappingProfile:Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<CourseDto, Course>().ReverseMap();
        }
    }
}
