namespace OnlineCourse.API.Extansions
{
    public static class RepositoryCollectionExtentions
    {
       public static void AddCustomRepository(this IServiceCollection services)
       {
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IBlogCategoryRepository, BlogCategoryRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
       }
    }
}
