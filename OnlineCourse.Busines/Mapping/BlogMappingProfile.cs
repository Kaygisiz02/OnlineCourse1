namespace OnlineCourse.Busines
{
    public class BlogMappingProfile:Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<BlogDto,Blog>().ReverseMap();
        }
    }
}
