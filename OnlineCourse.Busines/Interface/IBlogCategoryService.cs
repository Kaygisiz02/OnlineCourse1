namespace OnlineCourse.Busines
{
    public interface IBlogCategoryService
    {
        BlogCategoryDto GetBlogCategoryById(int id);
        IEnumerable<BlogCategoryDto> GetAllBlogCategories();
        bool AddBlogCategory(BlogCategoryDto blogCategory);
        bool UpdateBlogCategory(BlogCategoryDto blogCategory);
        bool DeleteBlogCategory(int id);
    }
}
