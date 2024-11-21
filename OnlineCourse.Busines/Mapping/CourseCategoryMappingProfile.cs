namespace OnlineCourse.Busines.Mapping
{
    public class CourseCategoryMappingProfile:Profile
    {
        public CourseCategoryMappingProfile()
        {
            CreateMap<CourseCategory, CourseCategoryDto>().ReverseMap();
        }
    }
}
