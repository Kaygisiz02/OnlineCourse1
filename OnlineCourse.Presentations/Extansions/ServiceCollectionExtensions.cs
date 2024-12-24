using OnlineCourse.Busines.Interface;

namespace OnlineCourse.Presentations
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAboutService,AboutService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogCategoryService, BlogCategoryService>();
            services.AddScoped<ICourseRegisterService, CourseRegisterService>();
            services.AddScoped<ICourseService, CourseServices>();
            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddScoped<IContactService, ContactServices>();
            services.AddScoped<IMessageService, MessageServices>();
            services.AddScoped<ISocialMediaService, SocialMediaServices>();
            services.AddScoped<ISubscribeService, SubscribeServices>();
            services.AddScoped<ITestimonialService, TestimonialServices>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
          
        }
    }
}
