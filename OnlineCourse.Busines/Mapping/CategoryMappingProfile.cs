namespace OnlineCourse.Busines
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CourseRegisterDto, CourseRegister>().ReverseMap();
        }
    }
}
