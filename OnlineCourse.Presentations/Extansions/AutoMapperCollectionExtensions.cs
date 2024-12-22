using OnlineCourse.Busines;
using OnlineCourse.Busines.Mapping;

namespace OnlineCourse.Presentations.Extansions
{
    public static class AutoMapperCollectionExtensions
    {
        public static void AddAutoMapperCustom(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AboutMappingProfile));
            services.AddAutoMapper(typeof(BannerMappingProfile));
            services.AddAutoMapper(typeof(BlogMappingProfile));
            services.AddAutoMapper(typeof(BlogCategoryMappingProfile));
            services.AddAutoMapper(typeof(CourseRegisterMappingProfile));
            services.AddAutoMapper(typeof(CourseMappingProfile));
            services.AddAutoMapper(typeof(CourseCategoryMappingProfile));
            services.AddAutoMapper(typeof(ContactMappingProfile));
            services.AddAutoMapper(typeof(MessageMappingProfile));
            services.AddAutoMapper(typeof(SocialMediaMappingProfile));
            services.AddAutoMapper(typeof(SubscribeMappingProfile));
            services.AddAutoMapper(typeof(TestimonialMappingProfile));
        }
    }

}
