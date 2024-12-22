namespace OnlineCourse.Busines
{
    public interface ICategoryService
    {
        CategoryDto GetCategoryById(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        bool UpdateCategory(CategoryDto category);
        bool AddCategory(CategoryDto category);
        bool RemovCategoty(int id);
    }
}
