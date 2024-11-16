namespace OnlineCourse.API.Extansions
{
    public static class AutoMapperCollectionExtensions
    {
        public static void AddAutoMapperCustom(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AboutMappingProfile));
            services.AddAutoMapper(typeof(BannerMappingProfile));
            services.AddAutoMapper(typeof(BlogMappingProfile));
            services.AddAutoMapper(typeof(BlogCategoryMappingProfile));
            services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddAutoMapper(typeof(CourseMappingProfile));
            services.AddAutoMapper(typeof(CourseCategoryMappingProfile));
            services.AddAutoMapper(typeof(ContactMappingProfile));
            services.AddAutoMapper(typeof(MessageMappingProfile));
        }
    }
    
}
