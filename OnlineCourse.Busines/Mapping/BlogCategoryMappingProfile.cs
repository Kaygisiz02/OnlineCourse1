namespace OnlineCourse.Busines
{
    public class BlogCategoryMappingProfile:Profile
    {
        public BlogCategoryMappingProfile()
        {
            CreateMap<BlogCategory, BlogCategoryDto>().ReverseMap();
        }
    }
}
