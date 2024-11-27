using GenFu;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace OnlineCourse.Entity
{
    public class OnlineCourseDbContext : DbContext
    {
        public OnlineCourseDbContext(DbContextOptions options) : base(options)
        {
         
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // GenFu kullanarak About tablosu için 3 tane rastgele veri oluştur
        //    var abouts = A.ListOf<About>(3);  // 3 tane fake About verisi oluştur
        //    modelBuilder.Entity<About>().HasData(abouts); // Veriyi About tablosuna ekle
        //    var banner=A.ListOf<Banner>(4);
        //    modelBuilder.Entity<Banner>().HasData(banner);
        //    var blogs=A.ListOf<Blog>(5);
        //    modelBuilder.Entity<Blog>().HasData(blogs);
        //    var blogCategories=A.ListOf<BlogCategory>(6);
        //    modelBuilder.Entity<BlogCategory>().HasData(blogCategories);
        //    var categories=A.ListOf<Category>(7);
        //    modelBuilder.Entity<Category>().HasData(categories);
        //    var contacts=A.ListOf<Contact>(7);
        //    modelBuilder.Entity<Contact>().HasData(contacts);
        //    var courses=A.ListOf<Course>(8);
        //    modelBuilder.Entity<Course>().HasData(courses);
        //    var categoryCourse=A.ListOf<CourseCategory>(8);
        //    modelBuilder.Entity<CourseCategory>().HasData(categoryCourse);
        //    var messegas=A.ListOf<Message>(10);
        //    modelBuilder.Entity<Message>().HasData(messegas);
        //    var socialMedias=A.ListOf<SocialMedia>(11);
        //    modelBuilder.Entity<SocialMedia>().HasData(socialMedias);
        //    var subscribes=A.ListOf<Subscribe>(12);
        //    modelBuilder.Entity<Subscribe>().HasData(subscribes);
        //    var testimonials=A.ListOf<Testimonial>(13);
        //    modelBuilder.Entity<Testimonial>().HasData(testimonials);

        //}
    }
}
