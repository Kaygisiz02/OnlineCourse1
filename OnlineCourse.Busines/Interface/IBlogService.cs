namespace OnlineCourse.Busines
{
    public interface IBlogService
    {
        BlogDto GetBlog(int id);
        List<BlogDto> GetAllBlog();
        bool AddBlog(BlogDto blog);
        bool DeleteBlog(int id);
        bool UpdateBlog(BlogDto blogDto);
        List<BlogDto> GetBlogsWithCategories();
    }
}
