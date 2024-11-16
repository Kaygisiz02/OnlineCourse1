namespace OnlineCourse.Busines.Mapping
{
    public class CourseCategoryMappingProfile:Profile
    {
        public CourseCategoryMappingProfile()
        {
            CreateMap<CourseCategoryDto, CourseCategory>().ReverseMap();
        }
    }
}
