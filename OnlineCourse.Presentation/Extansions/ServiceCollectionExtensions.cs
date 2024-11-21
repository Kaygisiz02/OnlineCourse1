using OnlineCourse.Busines;

namespace OnlineCourse.Presentation.Extansions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAboutService,AboutService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogCategoryService, BlogCategoryService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICourseService, CourseServices>();
            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddScoped<IContactService, ContactServices>();
            services.AddScoped<IMessageService, MessageServices>();
        }
    }
}
