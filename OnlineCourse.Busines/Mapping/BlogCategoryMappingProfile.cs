namespace OnlineCourse.Busines
{
    public class BlogCategoryMappingProfile:Profile
    {
        public BlogCategoryMappingProfile()
        {
            CreateMap<BlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
