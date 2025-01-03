﻿using OnlineCourse.Repository.Abstract;

namespace OnlineCourse.Presentations.Extansions
{
    public static class RepositoryCollectionExtentions
    {
       public static void AddCustomRepository(this IServiceCollection services)
       {
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IBlogCategoryRepository, BlogCategoryRepository>();
            services.AddScoped<ICourseRegisterRepository, CourseRegisterRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            services.AddScoped<ISubscribeRepository, SubscribeRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IUserService, UserService>();
       }
    }
}
