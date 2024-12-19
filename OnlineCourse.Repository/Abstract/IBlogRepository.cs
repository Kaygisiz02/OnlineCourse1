namespace OnlineCourse.Repository
{
    public interface IBlogRepository:IBaseRepository<Blog>
    {
        List<Blog> GetBlogWithCategories();
    }
}
