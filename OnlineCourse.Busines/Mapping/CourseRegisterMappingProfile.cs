namespace OnlineCourse.Busines
{
    public class CourseRegisterMappingProfile:Profile
    {
        public CourseRegisterMappingProfile()
        {
            CreateMap<CourseRegisterDto, CourseRegister>().ReverseMap();
        }
    }
}
