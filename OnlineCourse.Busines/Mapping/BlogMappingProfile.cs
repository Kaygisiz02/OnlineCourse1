namespace OnlineCourse.Busines
{
    public class BlogMappingProfile:Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<Blog, BlogDto>().ReverseMap();
        }
    }
}
