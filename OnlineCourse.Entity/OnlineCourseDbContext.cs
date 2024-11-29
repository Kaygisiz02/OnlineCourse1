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
        //    int counter = 1;
        //    // GenFu kullanarak About tablosu için 3 tane rastgele veri oluştur
        //    A.Configure<About>()
        //        .Fill(a => a.AboutId,()=>counter++)
        //        .Fill(a => a.ImageUrl1, "/images/about{0}.jpg")
        //        .Fill(a => a.ImageUrl2, "/images/about{0}.jpg")
        //        .Fill(a => a.Item1).AsLoremIpsumWords(1)
        //        .Fill(a => a.Item2).AsLoremIpsumWords(2)
        //        .Fill(a => a.Item3).AsLoremIpsumWords(3)
        //        .Fill(a => a.Item4).AsLoremIpsumWords(4);
        //    var abouts = A.ListOf<About>(3);  // 3 tane fake About verisi oluştur
        //    modelBuilder.Entity<About>().HasData(abouts); // Veriyi About tablosuna ekle
        //                                                  // Banner sahte verileri
        //    A.Configure<Banner>()
        //        .Fill(b => b.BannerId, () => counter++)
        //        .Fill(b => b.ImageUrl, "/images/banner{0}.jpg")
        //        .Fill(b => b.Description).AsLoremIpsumWords(3);
        //    var banner = A.ListOf<Banner>(4);
        //    modelBuilder.Entity<Banner>().HasData(banner);
        //    // Blog sahte verileri
        //    A.Configure<Blog>()
        //        .Fill(b => b.BlogId, () => counter++)
        //        .Fill(b => b.ImageUrl, "/images/blog{0}.jpg")
        //        .Fill(b => b.BlogCategoryId).WithinRange(1, 3);
        //    var blogs = A.ListOf<Blog>(5);
        //    modelBuilder.Entity<Blog>().HasData(blogs);

        //    // BlogCategory sahte verileri
        //    A.Configure<BlogCategory>()
        //        .Fill(b => b.BlogCategoryId, () => counter++)
        //        .Fill(b => b.BlogCategoryName).AsLoremIpsumWords(3);
        //    var blogCategories = A.ListOf<BlogCategory>(10);
        //    modelBuilder.Entity<BlogCategory>().HasData(blogCategories);
        //    // Category sahte verileri
        //    A.Configure<Category>()
        //        .Fill(c => c.CategoryId, () => counter++)
        //        .Fill(c => c.CategoryName).AsLoremIpsumWords(4)
        //        .Fill(c => c.Icon, "/images/blog{0}.jpg");
        //    var categories = A.ListOf<Category>(7);
        //    modelBuilder.Entity<Category>().HasData(categories);
        //    // Contact sahte verileri
        //    A.Configure<Contact>()
        //        .Fill(c => c.ContactId, () => counter++)
        //        .Fill(c=>c.Email).AsEmailAddress()
        //        .Fill(c=>c.PhoneNumber).AsPhoneNumber()
        //        .Fill(c=>c.MapUrl, ()=> $"https://www.google.com/maps?q={new Random().Next(-90, 90)},{new Random().Next(-180, 180)}");
        //    var contacts = A.ListOf<Contact>(7);
        //    modelBuilder.Entity<Contact>().HasData(contacts);
        //    // Course sahte verileri
        //    A.Configure<Course>()
        //        .Fill(c => c.CourseId, () => counter++)
        //        .Fill(c => c.CourseName).AsLoremIpsumWords(4)
        //        .Fill(c => c.CategoryId).WithinRange(1, 7)
        //        .Fill(c => c.Description).AsLoremIpsumWords(7)
        //        .Fill(c => c.Title).AsLoremIpsumWords(7)
        //        .Fill(c => c.ImageUrl, "/images/course{0}.jpg")
        //        .Fill(c => c.Price).WithinRange(10000, 50000);
        //    var courses = A.ListOf<Course>(4);
        //    modelBuilder.Entity<Course>().HasData(courses);
        //    A.Configure<CourseCategory>()
        //        .Fill(c => c.CourseCategoryId, () => counter++)
        //        .Fill(c => c.CourseCategoryName).AsLoremIpsumWords(4)
        //        .Fill(c => c.CourseId).WithinRange(1, 4)
        //        .Fill(c => c.CategoryId).WithinRange(1, 7);
        //    var categoryCourse = A.ListOf<CourseCategory>(8);
        //    modelBuilder.Entity<CourseCategory>().HasData(categoryCourse);
        //    A.Configure<Message>()
        //        .Fill(m => m.MesageId, () => counter++)
        //        .Fill(m => m.MessageName).AsFirstName()
        //        .Fill(m => m.Subject).AsLoremIpsumWords(3);
        //    var messegas = A.ListOf<Message>(10);
        //    modelBuilder.Entity<Message>().HasData(messegas);
        //    A.Configure<SocialMedia>()
        //        .Fill(s => s.SocialMediaId, () => counter++)
        //        .Fill(s => s.Title)
        //        .Fill(s => s.UrlLink, "/images/socialmedia{0}.jpg")
        //        .Fill(s => s.Icon, "/images/icon{0}.jpg");
        //    var socialMedias = A.ListOf<SocialMedia>(11);
        //    modelBuilder.Entity<SocialMedia>().HasData(socialMedias);
        //    A.Configure<Subscribe>()
        //        .Fill(s => s.SubscribeId, () => counter++)
        //        .Fill(s => s.Email).AsEmailAddress();
        //    var subscribes = A.ListOf<Subscribe>(8);
        //    modelBuilder.Entity<Subscribe>().HasData(subscribes);
        //    A.Configure<Testimonial>()
        //        .Fill(t => t.TestimonialId, () => counter++)
        //        .Fill(t => t.TestimonialName).AsFirstName()
        //        .Fill(t => t.Star, () => Math.Round(new Random().NextDouble() * (5 - 1) + 1, 1))
        //        .Fill(t => t.ImageUrl, "/images/socialmedia{0}.jpg");
        //    var testimonials = A.ListOf<Testimonial>(13);
        //    modelBuilder.Entity<Testimonial>().HasData(testimonials);

        //}
    }
}
